/*
 * 作者：张鹏
 * 时间：2014/2/28
 * 作用：盘古词库字典管理
 * 作用域：分词工具
 */
using PanGu.Dict;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ExtensionsLib;
using PanGu;

namespace PanGuHelper
{
      /// <summary>
      /// 盘古词库字典管理
      /// </summary>
      public class PanguDictManager
      {
            //批量添加事件
            public event EventHandler<BatchInsertProgressArgs> BatchInsertProgress;

            WordDictionary _dict = null;
            string _version = "";
            string _dictfilename = null;

            public PanguDictManager() { }

            /// <summary>
            /// 初始化字典
            /// </summary>
            /// <returns></returns>
            public int Load(string dictname)
            {
                  try
                  {
                        _dict = new WordDictionary();
                        _dict.ThrowIfNull("字典对象未初始化");
                        if (string.IsNullOrEmpty(dictname)) throw new ArgumentNullException("请指定字典文件");
                        if (!File.Exists(dictname)) throw new System.IO.FileNotFoundException("给定的字典文件不存在");
                        _dict.Load(dictname, out _version);
                        _dictfilename = dictname;
                        return _dict.Count;
                  }
                  catch (Exception)
                  {
                        throw;
                  }
            }

            /// <summary>
            /// 保存到文本文件
            /// </summary>
            /// <param name="filename"></param>
            /// <returns></returns>
            public bool SaveToText(string filename)
            {
                  try
                  {
                        _dict.ThrowIfNull("字典对象未初始化");
                        _dict.SaveToText(filename);
                        return true;
                  }
                  catch (Exception)
                  {
                        throw;
                  }
            }

            /// <summary>
            /// 保存
            /// </summary>
            /// <param name="filename">文件名</param>
            /// <param name="ver">版本号,建议用日期</param>
            /// <returns></returns>
            public bool Save(string filename, string ver = "")
            {
                  try
                  {
                        _dict.ThrowIfNull("字典对象未初始化");
                        (string.IsNullOrEmpty(ver)
                            ? new Action(() => _dict.Save(filename))
                            : new Action(() => _dict.Save(filename, ver)))
                            ();
                        return true;
                  }
                  catch (Exception)
                  {
                        throw;
                  }
            }

            /// <summary>
            /// 使用Load时的字典文件保存（更新）
            /// </summary>
            /// <returns></returns>
            public bool Save()
            {
                  try
                  {
                        _dict.ThrowIfNull("字典对象未初始化");
                        _dictfilename.ThrowIfNull("字典路径未定义");
                        _dict.Save(_dictfilename);
                        return true;
                  }
                  catch (Exception)
                  {

                        throw;
                  }
            }

            /// <summary>
            /// 移除单词
            /// </summary>
            /// <param name="word"></param>
            /// <returns></returns>
            public bool Remove(string word)
            {
                  try
                  {
                        _dict.ThrowIfNull("字典对象未初始化");
                        _dict.DeleteWord(word);
                        return true;
                  }
                  catch (Exception)
                  {
                        throw;
                  }

            }

            /// <summary>
            /// 
            /// </summary>
            public void Update(string word, double frequency, POS pos)
            {
                  _dict.UpdateWord(word, frequency, pos);
            }

            /// <summary>
            /// 插入
            /// </summary>
            /// <param name="word"></param>
            /// <param name="freq">词频</param>
            /// <param name="pos">词性</param>
            public void Insert(string word, double freq, POS pos)
            {
                  try
                  {
                        _dict.ThrowIfNull("字典对象未初始化");

                        if (_dict.Search(word).Count > 0)
                              _dict.UpdateWord(word, freq, pos);
                        else
                              _dict.InsertWord(word, freq, pos);

                  }
                  catch (Exception)
                  {
                        throw;
                  }
            }

            /// <summary>
            /// 插入
            /// </summary>
            /// <param name="word"></param>
            public void Insert(string word)
            {
                  //POS.POS_UNK 未知词性
                  Insert(word, 0, POS.POS_UNK);
            }

            /// <summary>
            /// 批量添加
            /// 文本文件应以 word|freq|pos 形式存储，若只包含单词，则词频为0，词性为未知
            /// </summary>
            /// <param name="fileName"></param>
            /// <param name="encoder">编码:utf8/gb2312</param>
            public void BatchInsert(string fileName, string encoder)
            {
                  string content = PanGu.Framework.File.ReadFileToString(fileName, Encoding.GetEncoding(encoder));
                  string[] words = PanGu.Framework.Regex.Split(content, @"\r\n");
                  int totalWords = words.Length;
                  int i = 0, errCount = 0, okCount = 0;

                  foreach (string word in words)
                  {
                        if (word == null) continue;
                        if (word.Trim() == "") continue;

                        string[] strs = word.Split(new char[] { '|' });

                        if (strs.Length == 3)
                        {
                              try
                              {
                                    POS pos = (POS)int.Parse(strs[1].Substring(2, strs[1].Length - 2),
                                        System.Globalization.NumberStyles.HexNumber);
                                    double frequency = double.Parse(strs[2]);
                                    string w = strs[0].Trim();
                                    _dict.InsertWord(w, frequency, pos);
                                    okCount++;
                              }
                              catch
                              {
                                    errCount++;
                              }
                        }
                        else if (strs.Length == 1)
                        {
                              try
                              {
                                    string w = strs[0].Trim();
                                    Insert(w);
                                    okCount++;
                              }
                              catch (Exception)
                              {
                                    errCount++;
                              }
                        }
                        else
                        {
                              errCount++;
                        }
                        i++;
                        //事件
                        if (BatchInsertProgress != null)
                              BatchInsertProgress(this, new BatchInsertProgressArgs()
                              {
                                    Percent = i * 100 / totalWords,
                                    ErrorCount = errCount,
                                    SuccessCount = okCount,
                                    TotalCount = totalWords
                              });
                  }
            }

            /// <summary>
            /// 批量插入，参数格式为 "string|词频|词性" or "string",如果不指定词频和词性，词频将默认为0，词性将默认为未知
            /// 
            /// </summary>
            /// <param name="wordList"></param>
            public void BatchInsert(IEnumerable<string> wordList)
            {
                  int totalWords = wordList.ToList().Count;
                  int i = 0, errCount = 0, okCount = 0;

                  foreach (string word in wordList)
                  {
                        if (word == null) continue;
                        if (word.Trim() == "") continue;

                        string[] strs = word.Split(new char[] { '|' });

                        if (strs.Length == 3)
                        {
                              try
                              {
                                    POS pos = (POS)int.Parse(strs[1].Substring(2, strs[1].Length - 2),
                                        System.Globalization.NumberStyles.HexNumber);
                                    double frequency = double.Parse(strs[2]);
                                    string w = strs[0].Trim();
                                    _dict.InsertWord(w, frequency, pos);
                                    okCount++;
                              }
                              catch
                              {
                                    errCount++;
                              }
                        }
                        else if (strs.Length == 1)
                        {
                              try
                              {
                                    string w = strs[0].Trim();
                                    Insert(w);
                                    okCount++;
                              }
                              catch (Exception)
                              {
                                    errCount++;
                              }
                        }
                        else
                        {
                              errCount++;
                        }
                        i++;
                        //事件
                        if (BatchInsertProgress != null)
                              BatchInsertProgress(this, new BatchInsertProgressArgs()
                              {
                                    Percent = i * 100 / totalWords,
                                    ErrorCount = errCount,
                                    SuccessCount = okCount,
                                    TotalCount = totalWords
                              });
                  }
            }
      }


}
