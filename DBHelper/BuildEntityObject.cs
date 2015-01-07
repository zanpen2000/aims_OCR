

 
using System;
using System.Collections.Generic;
using System.Text;


namespace Model
{     
				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("actionMetadata")]
				public class actionMetadata : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _parentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String parentId{ set { _parentId = value; changed("parentId");} get { return _parentId; } }

				
					private System.String _namespaceName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "namespaceName", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String namespaceName{ set { _namespaceName = value; changed("namespaceName");} get { return _namespaceName; } }

				
					private System.String _className = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "className", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String className{ set { _className = value; changed("className");} get { return _className; } }

				
					private System.String _interfaceName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "interfaceName", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String interfaceName{ set { _interfaceName = value; changed("interfaceName");} get { return _interfaceName; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.String _ParentName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ParentName", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String ParentName{ set { _ParentName = value; changed("ParentName");} get { return _ParentName; } }

				
					private System.String _sort = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "sort", FieldType = "tinyint", FieldRemark = "", Length = 3, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String sort{ set { _sort = value; changed("sort");} get { return _sort; } }

				
					private System.Boolean _IsMenu = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsMenu", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsMenu{ set { _IsMenu = value; changed("IsMenu");} get { return _IsMenu; } }

				
					private System.String _icon = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "icon", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String icon{ set { _icon = value; changed("icon");} get { return _icon; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("annualReport")]
				public class annualReport : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 20, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _Unit = "";
					/// <summary>
					/// 单位
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Unit", FieldType = "varchar", FieldRemark = "单位", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Unit{ set { _Unit = value; changed("Unit");} get { return _Unit; } }

				
					private System.String _UnitCode = "";
					/// <summary>
					/// 单位代码
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "UnitCode", FieldType = "varchar", FieldRemark = "单位代码", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String UnitCode{ set { _UnitCode = value; changed("UnitCode");} get { return _UnitCode; } }

				
					private System.String _Year = "";
					/// <summary>
					/// 年度
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Year", FieldType = "char", FieldRemark = "年度", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Year{ set { _Year = value; changed("Year");} get { return _Year; } }

				
					private System.Int32 _DelimitOranizational = 0;
					/// <summary>
					/// 定编
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "DelimitOranizational", FieldType = "int", FieldRemark = "定编", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 DelimitOranizational{ set { _DelimitOranizational = value; changed("DelimitOranizational");} get { return _DelimitOranizational; } }

				
					private System.Int32 _FullTimeNum = 0;
					/// <summary>
					/// 现有全部专职人员
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "FullTimeNum", FieldType = "int", FieldRemark = "现有全部专职人员", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 FullTimeNum{ set { _FullTimeNum = value; changed("FullTimeNum");} get { return _FullTimeNum; } }

				
					private System.Int32 _femaleFTNum = 0;
					/// <summary>
					/// 女性专员数目
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "femaleFTNum", FieldType = "int", FieldRemark = "女性专员数目", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 femaleFTNum{ set { _femaleFTNum = value; changed("femaleFTNum");} get { return _femaleFTNum; } }

				
					private System.Int32 _BureauNum = 0;
					/// <summary>
					/// 档案处
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "BureauNum", FieldType = "int", FieldRemark = "档案处", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 BureauNum{ set { _BureauNum = value; changed("BureauNum");} get { return _BureauNum; } }

				
					private System.Int32 _OfficeNum = 0;
					/// <summary>
					/// 档案室
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "OfficeNum", FieldType = "int", FieldRemark = "档案室", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 OfficeNum{ set { _OfficeNum = value; changed("OfficeNum");} get { return _OfficeNum; } }

				
					private System.String _FullTimeInfo = "";
					/// <summary>
					/// 全部专职人员情况
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "FullTimeInfo", FieldType = "varchar", FieldRemark = "全部专职人员情况", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String FullTimeInfo{ set { _FullTimeInfo = value; changed("FullTimeInfo");} get { return _FullTimeInfo; } }

				
					private System.Int32 _PartTimeNum = 0;
					/// <summary>
					/// 兼职人员
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "PartTimeNum", FieldType = "int", FieldRemark = "兼职人员", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 PartTimeNum{ set { _PartTimeNum = value; changed("PartTimeNum");} get { return _PartTimeNum; } }

				
					private System.String _AllRoomStored = "";
					/// <summary>
					/// 全部室存档案
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "AllRoomStored", FieldType = "varchar", FieldRemark = "全部室存档案", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String AllRoomStored{ set { _AllRoomStored = value; changed("AllRoomStored");} get { return _AllRoomStored; } }

				
					private System.String _LongTimeStored = "";
					/// <summary>
					/// 长期档案
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "LongTimeStored", FieldType = "varchar", FieldRemark = "长期档案", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String LongTimeStored{ set { _LongTimeStored = value; changed("LongTimeStored");} get { return _LongTimeStored; } }

				
					private System.String _ReceivedInfo = "";
					/// <summary>
					/// 本年接受档案
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ReceivedInfo", FieldType = "varchar", FieldRemark = "本年接受档案", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String ReceivedInfo{ set { _ReceivedInfo = value; changed("ReceivedInfo");} get { return _ReceivedInfo; } }

				
					private System.String _MovedInInfo = "";
					/// <summary>
					/// 本年移交进馆档案
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "MovedInInfo", FieldType = "varchar", FieldRemark = "本年移交进馆档案", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String MovedInInfo{ set { _MovedInInfo = value; changed("MovedInInfo");} get { return _MovedInInfo; } }

				
					private System.String _HistoricalDivision = "";
					/// <summary>
					/// 室存档案的历史分期
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "HistoricalDivision", FieldType = "varchar", FieldRemark = "室存档案的历史分期", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String HistoricalDivision{ set { _HistoricalDivision = value; changed("HistoricalDivision");} get { return _HistoricalDivision; } }

				
					private System.Int32 _Material = 0;
					/// <summary>
					/// 室存资料
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Material", FieldType = "int", FieldRemark = "室存资料", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 Material{ set { _Material = value; changed("Material");} get { return _Material; } }

				
					private System.String _CatalogInfo = "";
					/// <summary>
					/// 档案编目情况
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CatalogInfo", FieldType = "varchar", FieldRemark = "档案编目情况", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CatalogInfo{ set { _CatalogInfo = value; changed("CatalogInfo");} get { return _CatalogInfo; } }

				
					private System.Int32 _ArchiveUtilizationTimes = 0;
					/// <summary>
					/// 本年利用档案人次
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ArchiveUtilizationTimes", FieldType = "int", FieldRemark = "本年利用档案人次", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 ArchiveUtilizationTimes{ set { _ArchiveUtilizationTimes = value; changed("ArchiveUtilizationTimes");} get { return _ArchiveUtilizationTimes; } }

				
					private System.String _UtilizationInfo = "";
					/// <summary>
					/// 本年利用档案
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "UtilizationInfo", FieldType = "varchar", FieldRemark = "本年利用档案", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String UtilizationInfo{ set { _UtilizationInfo = value; changed("UtilizationInfo");} get { return _UtilizationInfo; } }

				
					private System.Int32 _MaterialUtilizationTimes = 0;
					/// <summary>
					/// 本年利用资料人次
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "MaterialUtilizationTimes", FieldType = "int", FieldRemark = "本年利用资料人次", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 MaterialUtilizationTimes{ set { _MaterialUtilizationTimes = value; changed("MaterialUtilizationTimes");} get { return _MaterialUtilizationTimes; } }

				
					private System.Int32 _MaterialUtilizationvolume = 0;
					/// <summary>
					/// 本年利用资料
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "MaterialUtilizationvolume", FieldType = "int", FieldRemark = "本年利用资料", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 MaterialUtilizationvolume{ set { _MaterialUtilizationvolume = value; changed("MaterialUtilizationvolume");} get { return _MaterialUtilizationvolume; } }

				
					private System.Int32 _CopyAmout = 0;
					/// <summary>
					/// 本年复制档案资料
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CopyAmout", FieldType = "int", FieldRemark = "本年复制档案资料", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 CopyAmout{ set { _CopyAmout = value; changed("CopyAmout");} get { return _CopyAmout; } }

				
					private System.String _EditStudyMaterial = "";
					/// <summary>
					/// 本年编研档案资料
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "EditStudyMaterial", FieldType = "varchar", FieldRemark = "本年编研档案资料", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String EditStudyMaterial{ set { _EditStudyMaterial = value; changed("EditStudyMaterial");} get { return _EditStudyMaterial; } }

				
					private System.Decimal _BuiltupArea = 0;
					/// <summary>
					/// 档案室总建筑面积
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "BuiltupArea", FieldType = "float", FieldRemark = "档案室总建筑面积", Length = 53, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Decimal BuiltupArea{ set { _BuiltupArea = value; changed("BuiltupArea");} get { return _BuiltupArea; } }

				
					private System.Decimal _StoreroomArea = 0;
					/// <summary>
					/// 档案库房建筑面积
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "StoreroomArea", FieldType = "float", FieldRemark = "档案库房建筑面积", Length = 53, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Decimal StoreroomArea{ set { _StoreroomArea = value; changed("StoreroomArea");} get { return _StoreroomArea; } }

				
					private System.String _Equipment = "";
					/// <summary>
					/// 档案室设备
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Equipment", FieldType = "varchar", FieldRemark = "档案室设备", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Equipment{ set { _Equipment = value; changed("Equipment");} get { return _Equipment; } }

				
					private System.String _Principal = "";
					/// <summary>
					/// 单位负责人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Principal", FieldType = "varchar", FieldRemark = "单位负责人", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Principal{ set { _Principal = value; changed("Principal");} get { return _Principal; } }

				
					private System.String _Tabulator = "";
					/// <summary>
					/// 制表人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Tabulator", FieldType = "varchar", FieldRemark = "制表人", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Tabulator{ set { _Tabulator = value; changed("Tabulator");} get { return _Tabulator; } }

				
					private System.DateTime? _ActualDate = null;
					/// <summary>
					/// 实际报出日期
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ActualDate", FieldType = "datetime", FieldRemark = "实际报出日期", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? ActualDate{ set { _ActualDate = value; changed("ActualDate");} get { return _ActualDate; } }

				
					private System.String _PostScript = "";
					/// <summary>
					/// 备注
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "PostScript", FieldType = "varchar", FieldRemark = "备注", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String PostScript{ set { _PostScript = value; changed("PostScript");} get { return _PostScript; } }

				
					private System.DateTime? _ModifyDate = null;
					/// <summary>
					/// 修改日期
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ModifyDate", FieldType = "datetime", FieldRemark = "修改日期", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? ModifyDate{ set { _ModifyDate = value; changed("ModifyDate");} get { return _ModifyDate; } }

				
					private System.DateTime? _CreateDate = null;
					/// <summary>
					/// 创建日期
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateDate", FieldType = "datetime", FieldRemark = "创建日期", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? CreateDate{ set { _CreateDate = value; changed("CreateDate");} get { return _CreateDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 是否逻辑删除
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "是否逻辑删除", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("appSystem")]
				public class appSystem : Entity
				{
					
			
					private System.String _systemID = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "systemID", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String systemID{ set { _systemID = value; changed("systemID");} get { return _systemID; } }

				
					private System.String _systemName = "";
					/// <summary>
					/// 字段名
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "systemName", FieldType = "varchar", FieldRemark = "字段名", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String systemName{ set { _systemName = value; changed("systemName");} get { return _systemName; } }

				
					private System.String _systemContent = "";
					/// <summary>
					/// 字段描述
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "systemContent", FieldType = "varchar", FieldRemark = "字段描述", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String systemContent{ set { _systemContent = value; changed("systemContent");} get { return _systemContent; } }

				
					private System.String _systemValue = "";
					/// <summary>
					/// 初始值
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "systemValue", FieldType = "varchar", FieldRemark = "初始值", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String systemValue{ set { _systemValue = value; changed("systemValue");} get { return _systemValue; } }

				
					private System.String _systemIsDelete = "";
					/// <summary>
					/// 是否删除
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "systemIsDelete", FieldType = "char", FieldRemark = "是否删除", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String systemIsDelete{ set { _systemIsDelete = value; changed("systemIsDelete");} get { return _systemIsDelete; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 修改时间
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "修改时间", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 创建时间
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "创建时间", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("ArchiveFileCheck")]
				public class ArchiveFileCheck : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.String _volumename = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volumename", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volumename{ set { _volumename = value; changed("volumename");} get { return _volumename; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _subjects = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjects", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjects{ set { _subjects = value; changed("subjects");} get { return _subjects; } }

				
					private System.String _foundName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundName{ set { _foundName = value; changed("foundName");} get { return _foundName; } }

				
					private System.String _storetime = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "storetime", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String storetime{ set { _storetime = value; changed("storetime");} get { return _storetime; } }

				
					private System.String _security = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "security", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String security{ set { _security = value; changed("security");} get { return _security; } }

				
					private System.DateTime? _startTime = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "startTime", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? startTime{ set { _startTime = value; changed("startTime");} get { return _startTime; } }

				
					private System.DateTime? _endTime = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "endTime", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? endTime{ set { _endTime = value; changed("endTime");} get { return _endTime; } }

				
					private System.String _applicationoption = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "applicationoption", FieldType = "varchar", FieldRemark = "", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String applicationoption{ set { _applicationoption = value; changed("applicationoption");} get { return _applicationoption; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.String _checkOpinion = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "checkOpinion", FieldType = "varchar", FieldRemark = "", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String checkOpinion{ set { _checkOpinion = value; changed("checkOpinion");} get { return _checkOpinion; } }

				
					private System.String _checkusername = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "checkusername", FieldType = "nchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String checkusername{ set { _checkusername = value; changed("checkusername");} get { return _checkusername; } }

				
					private System.String _checkUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "checkUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String checkUser{ set { _checkUser = value; changed("checkUser");} get { return _checkUser; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.String _applicationer = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "applicationer", FieldType = "nchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String applicationer{ set { _applicationer = value; changed("applicationer");} get { return _applicationer; } }

				
					private System.String _volumeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volumeId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volumeId{ set { _volumeId = value; changed("volumeId");} get { return _volumeId; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.String _state = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.String _fatherstate = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "fatherstate", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String fatherstate{ set { _fatherstate = value; changed("fatherstate");} get { return _fatherstate; } }

				
					private System.String _backuser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "backuser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String backuser{ set { _backuser = value; changed("backuser");} get { return _backuser; } }

				
					private System.String _backopinion = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "backopinion", FieldType = "varchar", FieldRemark = "", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String backopinion{ set { _backopinion = value; changed("backopinion");} get { return _backopinion; } }

				
					private System.DateTime? _modifydate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifydate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifydate{ set { _modifydate = value; changed("modifydate");} get { return _modifydate; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("ArchiveFileView")]
				public class ArchiveFileView : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _contectCode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "contectCode", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String contectCode{ set { _contectCode = value; changed("contectCode");} get { return _contectCode; } }

				
					private System.String _VolumeName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "VolumeName", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String VolumeName{ set { _VolumeName = value; changed("VolumeName");} get { return _VolumeName; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _subjects = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjects", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjects{ set { _subjects = value; changed("subjects");} get { return _subjects; } }

				
					private System.String _StoreTime = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "StoreTime", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String StoreTime{ set { _StoreTime = value; changed("StoreTime");} get { return _StoreTime; } }

				
					private System.String _foundName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundName{ set { _foundName = value; changed("foundName");} get { return _foundName; } }

				
					private System.String _year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.String _volumeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volumeId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volumeId{ set { _volumeId = value; changed("volumeId");} get { return _volumeId; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.String _securityId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String securityId{ set { _securityId = value; changed("securityId");} get { return _securityId; } }

				
					private System.String _organization = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organization", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organization{ set { _organization = value; changed("organization");} get { return _organization; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.String _securityName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityName{ set { _securityName = value; changed("securityName");} get { return _securityName; } }

				
					private System.String _organizName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organizName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organizName{ set { _organizName = value; changed("organizName");} get { return _organizName; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("CanRead")]
				public class CanRead : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _userId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "userId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String userId{ set { _userId = value; changed("userId");} get { return _userId; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("CheckFileView")]
				public class CheckFileView : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.Boolean _isCheck = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "isCheck", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean isCheck{ set { _isCheck = value; changed("isCheck");} get { return _isCheck; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeActionGroup")]
				public class codeActionGroup : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				}


				
				/// <summary>
				/// 功能表
				/// </summary>
				[DataEntityAttribute("codeActions")]
				public class codeActions : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _groupId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "groupId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String groupId{ set { _groupId = value; changed("groupId");} get { return _groupId; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.String _interfaceName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "interfaceName", FieldType = "varchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String interfaceName{ set { _interfaceName = value; changed("interfaceName");} get { return _interfaceName; } }

				
					private System.String _className = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "className", FieldType = "varchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String className{ set { _className = value; changed("className");} get { return _className; } }

				
					private System.String _metadataId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "metadataId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String metadataId{ set { _metadataId = value; changed("metadataId");} get { return _metadataId; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				}


				
				/// <summary>
				/// 柜体表
				/// </summary>
				[DataEntityAttribute("codeCabinets")]
				public class codeCabinets : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.Int32 _columnOrder = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "columnOrder", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Int32 columnOrder{ set { _columnOrder = value; changed("columnOrder");} get { return _columnOrder; } }

				
					private System.String _libraryId = "";
					/// <summary>
					/// 馆室
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "libraryId", FieldType = "char", FieldRemark = "馆室", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String libraryId{ set { _libraryId = value; changed("libraryId");} get { return _libraryId; } }

				
					private System.Int32 _rowOrder = 0;
					/// <summary>
					/// 第几排
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "rowOrder", FieldType = "int", FieldRemark = "第几排", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Int32 rowOrder{ set { _rowOrder = value; changed("rowOrder");} get { return _rowOrder; } }

				
					private System.Int32 _layCount = 0;
					/// <summary>
					/// 总层数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "layCount", FieldType = "int", FieldRemark = "总层数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Int32 layCount{ set { _layCount = value; changed("layCount");} get { return _layCount; } }

				
					private System.Int32 _caseCount = 0;
					/// <summary>
					/// 每层箱子数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "caseCount", FieldType = "int", FieldRemark = "每层箱子数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Int32 caseCount{ set { _caseCount = value; changed("caseCount");} get { return _caseCount; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 客户端mac地址注册
				/// </summary>
				[DataEntityAttribute("codeClientMac")]
				public class codeClientMac : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _macAddress = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "macAddress", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String macAddress{ set { _macAddress = value; changed("macAddress");} get { return _macAddress; } }

				
					private System.String _memo = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "memo", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String memo{ set { _memo = value; changed("memo");} get { return _memo; } }

				
					private System.String _userId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "userId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String userId{ set { _userId = value; changed("userId");} get { return _userId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeDepartments")]
				public class codeDepartments : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 部门管理
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "部门管理", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _text = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "text", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String text{ set { _text = value; changed("text");} get { return _text; } }

				
					private System.String _parentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String parentId{ set { _parentId = value; changed("parentId");} get { return _parentId; } }

				
					private System.String _memo = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "memo", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String memo{ set { _memo = value; changed("memo");} get { return _memo; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime _createDate = DateTime.Now;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.DateTime createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime _modifyDate = DateTime.Now;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.DateTime modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeDevices")]
				public class codeDevices : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _macAddress = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "macAddress", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String macAddress{ set { _macAddress = value; changed("macAddress");} get { return _macAddress; } }

				
					private System.String _IPAddress = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IPAddress", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String IPAddress{ set { _IPAddress = value; changed("IPAddress");} get { return _IPAddress; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.Int32 _sort = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "sort", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 sort{ set { _sort = value; changed("sort");} get { return _sort; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 处理方式字典表
				/// </summary>
				[DataEntityAttribute("codeDispose")]
				public class codeDispose : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeDocumenttype")]
				public class codeDocumenttype : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _parentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String parentId{ set { _parentId = value; changed("parentId");} get { return _parentId; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.Int32 _sort = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "sort", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 sort{ set { _sort = value; changed("sort");} get { return _sort; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 设施表
				/// </summary>
				[DataEntityAttribute("codefacility")]
				public class codefacility : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 设施名称
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "设施名称", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 设施维修保养记录表
				/// </summary>
				[DataEntityAttribute("codefacilitymaintenance")]
				public class codefacilitymaintenance : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 设施名称
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "设施名称", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _responsibility = "";
					/// <summary>
					/// 负责人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "responsibility", FieldType = "varchar", FieldRemark = "负责人", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String responsibility{ set { _responsibility = value; changed("responsibility");} get { return _responsibility; } }

				
					private System.String _facilitiyId = "";
					/// <summary>
					/// 设备编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "facilitiyId", FieldType = "char", FieldRemark = "设备编号", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String facilitiyId{ set { _facilitiyId = value; changed("facilitiyId");} get { return _facilitiyId; } }

				
					private System.DateTime? _date = null;
					/// <summary>
					/// 维修保养时间
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "date", FieldType = "date", FieldRemark = "维修保养时间", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? date{ set { _date = value; changed("date");} get { return _date; } }

				
					private System.String _description = "";
					/// <summary>
					/// 维修保养说明
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "维修保养说明", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 处理状态父表
				/// </summary>
				[DataEntityAttribute("codeFatherState")]
				public class codeFatherState : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 档案盒
				/// </summary>
				[DataEntityAttribute("codeFileBox")]
				public class codeFileBox : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 档案盒名称
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "档案盒名称", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _length = "";
					/// <summary>
					/// 档案盒长度
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "length", FieldType = "varchar", FieldRemark = "档案盒长度", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String length{ set { _length = value; changed("length");} get { return _length; } }

				
					private System.String _width = "";
					/// <summary>
					/// 档案盒宽度
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "width", FieldType = "varchar", FieldRemark = "档案盒宽度", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String width{ set { _width = value; changed("width");} get { return _width; } }

				
					private System.String _high = "";
					/// <summary>
					/// 档案盒高度
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "high", FieldType = "varchar", FieldRemark = "档案盒高度", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String high{ set { _high = value; changed("high");} get { return _high; } }

				
					private System.String _weight = "";
					/// <summary>
					/// 档案盒重量
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "weight", FieldType = "varchar", FieldRemark = "档案盒重量", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String weight{ set { _weight = value; changed("weight");} get { return _weight; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeFileClasses")]
				public class codeFileClasses : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _parentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String parentId{ set { _parentId = value; changed("parentId");} get { return _parentId; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.Int32 _sort = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "sort", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 sort{ set { _sort = value; changed("sort");} get { return _sort; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 文件类型
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "文件类型", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeFilesNumberRules")]
				public class codeFilesNumberRules : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.Int32 _sort = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "sort", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 sort{ set { _sort = value; changed("sort");} get { return _sort; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeFilesStructure")]
				public class codeFilesStructure : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _FileID = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "FileID", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String FileID{ set { _FileID = value; changed("FileID");} get { return _FileID; } }

				
					private System.String _DocumentClass = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "DocumentClass", FieldType = "char", FieldRemark = "", Length = 40, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String DocumentClass{ set { _DocumentClass = value; changed("DocumentClass");} get { return _DocumentClass; } }

				
					private System.Int32 _OriginalCountr = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "OriginalCountr", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 OriginalCountr{ set { _OriginalCountr = value; changed("OriginalCountr");} get { return _OriginalCountr; } }

				
					private System.Int32 _CopyCount = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CopyCount", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 CopyCount{ set { _CopyCount = value; changed("CopyCount");} get { return _CopyCount; } }

				
					private System.Int32 _ImageCount = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ImageCount", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 ImageCount{ set { _ImageCount = value; changed("ImageCount");} get { return _ImageCount; } }

				
					private System.Int32 _PageBegin = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "PageBegin", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 PageBegin{ set { _PageBegin = value; changed("PageBegin");} get { return _PageBegin; } }

				
					private System.Int32 _PageEnd = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "PageEnd", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 PageEnd{ set { _PageEnd = value; changed("PageEnd");} get { return _PageEnd; } }

				
					private System.Int32 _Sort = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Sort", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 Sort{ set { _Sort = value; changed("Sort");} get { return _Sort; } }

				
					private System.String _Responsible = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Responsible", FieldType = "varchar", FieldRemark = "", Length = 200, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Responsible{ set { _Responsible = value; changed("Responsible");} get { return _Responsible; } }

				
					private System.String _DocumentNumber = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "DocumentNumber", FieldType = "varchar", FieldRemark = "", Length = 200, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String DocumentNumber{ set { _DocumentNumber = value; changed("DocumentNumber");} get { return _DocumentNumber; } }

				
					private System.String _DocumentTitle = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "DocumentTitle", FieldType = "varchar", FieldRemark = "", Length = 200, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String DocumentTitle{ set { _DocumentTitle = value; changed("DocumentTitle");} get { return _DocumentTitle; } }

				
					private System.String _DocumentDate = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "DocumentDate", FieldType = "varchar", FieldRemark = "", Length = 200, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String DocumentDate{ set { _DocumentDate = value; changed("DocumentDate");} get { return _DocumentDate; } }

				
					private System.String _Remark = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Remark", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Remark{ set { _Remark = value; changed("Remark");} get { return _Remark; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 流程表
				/// </summary>
				[DataEntityAttribute("codeFlow")]
				public class codeFlow : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 全宗号字典表
				/// </summary>
				[DataEntityAttribute("codeFound")]
				public class codeFound : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _foundName = "";
					/// <summary>
					/// 组织机构名称
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundName", FieldType = "varchar", FieldRemark = "组织机构名称", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundName{ set { _foundName = value; changed("foundName");} get { return _foundName; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeGroupMap")]
				public class codeGroupMap : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _groupId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "groupId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String groupId{ set { _groupId = value; changed("groupId");} get { return _groupId; } }

				
					private System.String _departmentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "departmentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String departmentId{ set { _departmentId = value; changed("departmentId");} get { return _departmentId; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				}


				
				/// <summary>
				/// 馆室表
				/// </summary>
				[DataEntityAttribute("codeLibrary")]
				public class codeLibrary : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 馆室名称
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "馆室名称", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _groudLoad = "";
					/// <summary>
					/// 地面承重
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "groudLoad", FieldType = "varchar", FieldRemark = "地面承重", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String groudLoad{ set { _groudLoad = value; changed("groudLoad");} get { return _groudLoad; } }

				
					private System.Int32 _rows = 0;
					/// <summary>
					/// 排总数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "rows", FieldType = "int", FieldRemark = "排总数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 rows{ set { _rows = value; changed("rows");} get { return _rows; } }

				
					private System.Int32 _cabinetLevel = 0;
					/// <summary>
					/// 柜体层数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "cabinetLevel", FieldType = "int", FieldRemark = "柜体层数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 cabinetLevel{ set { _cabinetLevel = value; changed("cabinetLevel");} get { return _cabinetLevel; } }

				
					private System.String _cabinetLength = "";
					/// <summary>
					/// 柜体宽度
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "cabinetLength", FieldType = "varchar", FieldRemark = "柜体宽度", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String cabinetLength{ set { _cabinetLength = value; changed("cabinetLength");} get { return _cabinetLength; } }

				
					private System.String _cabinetWeight = "";
					/// <summary>
					/// 柜体重量
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "cabinetWeight", FieldType = "varchar", FieldRemark = "柜体重量", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String cabinetWeight{ set { _cabinetWeight = value; changed("cabinetWeight");} get { return _cabinetWeight; } }

				
					private System.String _boxLength = "";
					/// <summary>
					/// 档案盒长度
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "boxLength", FieldType = "varchar", FieldRemark = "档案盒长度", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String boxLength{ set { _boxLength = value; changed("boxLength");} get { return _boxLength; } }

				
					private System.String _boxWidth = "";
					/// <summary>
					/// 档案盒宽度
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "boxWidth", FieldType = "varchar", FieldRemark = "档案盒宽度", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String boxWidth{ set { _boxWidth = value; changed("boxWidth");} get { return _boxWidth; } }

				
					private System.String _boxWeight = "";
					/// <summary>
					/// 档案盒重量
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "boxWeight", FieldType = "varchar", FieldRemark = "档案盒重量", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String boxWeight{ set { _boxWeight = value; changed("boxWeight");} get { return _boxWeight; } }

				
					private System.String _doorLength = "";
					/// <summary>
					/// 门宽
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "doorLength", FieldType = "varchar", FieldRemark = "门宽", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String doorLength{ set { _doorLength = value; changed("doorLength");} get { return _doorLength; } }

				
					private System.String _doorHigh = "";
					/// <summary>
					/// 门高
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "doorHigh", FieldType = "varchar", FieldRemark = "门高", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String doorHigh{ set { _doorHigh = value; changed("doorHigh");} get { return _doorHigh; } }

				
					private System.String _highTemperature = "";
					/// <summary>
					/// 温度上限
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "highTemperature", FieldType = "varchar", FieldRemark = "温度上限", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String highTemperature{ set { _highTemperature = value; changed("highTemperature");} get { return _highTemperature; } }

				
					private System.String _lowTemperature = "";
					/// <summary>
					/// 温度下限
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "lowTemperature", FieldType = "varchar", FieldRemark = "温度下限", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String lowTemperature{ set { _lowTemperature = value; changed("lowTemperature");} get { return _lowTemperature; } }

				
					private System.String _highHumidity = "";
					/// <summary>
					/// 湿度上限
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "highHumidity", FieldType = "varchar", FieldRemark = "湿度上限", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String highHumidity{ set { _highHumidity = value; changed("highHumidity");} get { return _highHumidity; } }

				
					private System.String _lowHumidity = "";
					/// <summary>
					/// 湿度下限
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "lowHumidity", FieldType = "varchar", FieldRemark = "湿度下限", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String lowHumidity{ set { _lowHumidity = value; changed("lowHumidity");} get { return _lowHumidity; } }

				
					private System.String _facilityIds = "";
					/// <summary>
					/// 已有设备id
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "facilityIds", FieldType = "varchar", FieldRemark = "已有设备id", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String facilityIds{ set { _facilityIds = value; changed("facilityIds");} get { return _facilityIds; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 被操作对象字典表
				/// </summary>
				[DataEntityAttribute("codeOperatingObject")]
				public class codeOperatingObject : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				}


				
				/// <summary>
				/// 用户操作字典，如进入，离开，点击，删除
				/// </summary>
				[DataEntityAttribute("codeOperation")]
				public class codeOperation : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				}


				
				/// <summary>
				/// 角色字典表
                ///主要对应发文过程中拟稿人、审稿人、核稿人、签发人的角色设置，包括角色和角色对应的部门。
				/// </summary>
				[DataEntityAttribute("codeOrganization")]
				public class codeOrganization : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _organizName = "";
					/// <summary>
					/// 组织机构名称
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organizName", FieldType = "nvarchar", FieldRemark = "组织机构名称", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organizName{ set { _organizName = value; changed("organizName");} get { return _organizName; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.String _parentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String parentId{ set { _parentId = value; changed("parentId");} get { return _parentId; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeOrganization2")]
				public class codeOrganization2 : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _organizName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organizName", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organizName{ set { _organizName = value; changed("organizName");} get { return _organizName; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.String _parentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String parentId{ set { _parentId = value; changed("parentId");} get { return _parentId; } }

				}


				
				/// <summary>
				/// 角色字典表
   ///主要对应发文过程中拟稿人、审稿人、核稿人、签发人的角色设置，包括角色和角色对应的部门。
				/// </summary>
				[DataEntityAttribute("codeRole")]
				public class codeRole : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _roleName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "roleName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String roleName{ set { _roleName = value; changed("roleName");} get { return _roleName; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeRoles")]
				public class codeRoles : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeScanningFiles")]
				public class codeScanningFiles : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 20, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _DocketNo = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "DocketNo", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String DocketNo{ set { _DocketNo = value; changed("DocketNo");} get { return _DocketNo; } }

				
					private System.String _FileName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "FileName", FieldType = "varchar", FieldRemark = "", Length = 300, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String FileName{ set { _FileName = value; changed("FileName");} get { return _FileName; } }

				
					private System.String _FondsNumber = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "FondsNumber", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String FondsNumber{ set { _FondsNumber = value; changed("FondsNumber");} get { return _FondsNumber; } }

				
					private System.String _DepartmentNumber = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "DepartmentNumber", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String DepartmentNumber{ set { _DepartmentNumber = value; changed("DepartmentNumber");} get { return _DepartmentNumber; } }

				
					private System.String _Year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Year{ set { _Year = value; changed("Year");} get { return _Year; } }

				
					private System.String _ClassNumber = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ClassNumber", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String ClassNumber{ set { _ClassNumber = value; changed("ClassNumber");} get { return _ClassNumber; } }

				
					private System.String _SerialNumber = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "SerialNumber", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String SerialNumber{ set { _SerialNumber = value; changed("SerialNumber");} get { return _SerialNumber; } }

				
					private System.String _StoreTime = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "StoreTime", FieldType = "varchar", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String StoreTime{ set { _StoreTime = value; changed("StoreTime");} get { return _StoreTime; } }

				
					private System.String _Remark = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Remark", FieldType = "varchar", FieldRemark = "", Length = 200, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Remark{ set { _Remark = value; changed("Remark");} get { return _Remark; } }

				
					private System.String _UploadUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "UploadUser", FieldType = "varchar", FieldRemark = "", Length = 8, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String UploadUser{ set { _UploadUser = value; changed("UploadUser");} get { return _UploadUser; } }

				
					private System.DateTime? _UploadTime = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "UploadTime", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? UploadTime{ set { _UploadTime = value; changed("UploadTime");} get { return _UploadTime; } }

				
					private System.String _UploadIP = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "UploadIP", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String UploadIP{ set { _UploadIP = value; changed("UploadIP");} get { return _UploadIP; } }

				
					private System.Boolean _IsCheck = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsCheck", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsCheck{ set { _IsCheck = value; changed("IsCheck");} get { return _IsCheck; } }

				
					private System.String _CheckUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CheckUser", FieldType = "varchar", FieldRemark = "", Length = 8, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CheckUser{ set { _CheckUser = value; changed("CheckUser");} get { return _CheckUser; } }

				
					private System.DateTime? _CheckTime = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CheckTime", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? CheckTime{ set { _CheckTime = value; changed("CheckTime");} get { return _CheckTime; } }

				
					private System.Boolean _IsExtract = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsExtract", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsExtract{ set { _IsExtract = value; changed("IsExtract");} get { return _IsExtract; } }

				
					private System.String _ExtractUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ExtractUser", FieldType = "varchar", FieldRemark = "", Length = 8, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String ExtractUser{ set { _ExtractUser = value; changed("ExtractUser");} get { return _ExtractUser; } }

				
					private System.DateTime? _ExtractTime = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ExtractTime", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? ExtractTime{ set { _ExtractTime = value; changed("ExtractTime");} get { return _ExtractTime; } }

				
					private System.String _FilePath = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "FilePath", FieldType = "varchar", FieldRemark = "", Length = 300, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String FilePath{ set { _FilePath = value; changed("FilePath");} get { return _FilePath; } }

				
					private System.Int32 _ImageCount = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ImageCount", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 ImageCount{ set { _ImageCount = value; changed("ImageCount");} get { return _ImageCount; } }

				
					private System.Boolean _NeedRescan = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "NeedRescan", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean NeedRescan{ set { _NeedRescan = value; changed("NeedRescan");} get { return _NeedRescan; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeScanninggroup")]
				public class codeScanninggroup : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _parentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String parentId{ set { _parentId = value; changed("parentId");} get { return _parentId; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.Int32 _sort = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "sort", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 sort{ set { _sort = value; changed("sort");} get { return _sort; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "nchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 密级字典表
				/// </summary>
				[DataEntityAttribute("codeSecurity")]
				public class codeSecurity : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeSettingGroups")]
				public class codeSettingGroups : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeSettings")]
				public class codeSettings : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _groupId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "groupId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String groupId{ set { _groupId = value; changed("groupId");} get { return _groupId; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.String _value = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "value", FieldType = "varchar", FieldRemark = "", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String value{ set { _value = value; changed("value");} get { return _value; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 处理状态
				/// </summary>
				[DataEntityAttribute("codeState")]
				public class codeState : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.String _tag = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "tag", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String tag{ set { _tag = value; changed("tag");} get { return _tag; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeStoreTime")]
				public class codeStoreTime : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.Int32 _sort = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "sort", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 sort{ set { _sort = value; changed("sort");} get { return _sort; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 文件处理表编号
   ///主要在历史记录中记录操作的表格编号
				/// </summary>
				[DataEntityAttribute("codeTablesOperate")]
				public class codeTablesOperate : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _tableName = "";
					/// <summary>
					/// 表格名称
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "tableName", FieldType = "varchar", FieldRemark = "表格名称", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String tableName{ set { _tableName = value; changed("tableName");} get { return _tableName; } }

				
					private System.String _discription = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "discription", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String discription{ set { _discription = value; changed("discription");} get { return _discription; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 处理类型表
				/// </summary>
				[DataEntityAttribute("codeType")]
				public class codeType : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("codeUsers")]
				public class codeUsers : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "nchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _departmentId = "";
					/// <summary>
					/// 部门Id
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "departmentId", FieldType = "char", FieldRemark = "部门Id", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String departmentId{ set { _departmentId = value; changed("departmentId");} get { return _departmentId; } }

				
					private System.String _roleId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "roleId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String roleId{ set { _roleId = value; changed("roleId");} get { return _roleId; } }

				
					private System.String _securityId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityId{ set { _securityId = value; changed("securityId");} get { return _securityId; } }

				
					private System.String _loginName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "loginName", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String loginName{ set { _loginName = value; changed("loginName");} get { return _loginName; } }

				
					private System.String _password = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "password", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String password{ set { _password = value; changed("password");} get { return _password; } }

				
					private System.String _identityCardNum = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "identityCardNum", FieldType = "varchar", FieldRemark = "", Length = 18, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String identityCardNum{ set { _identityCardNum = value; changed("identityCardNum");} get { return _identityCardNum; } }

				
					private System.String _address = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "address", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String address{ set { _address = value; changed("address");} get { return _address; } }

				
					private System.String _phone = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "phone", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String phone{ set { _phone = value; changed("phone");} get { return _phone; } }

				
					private System.String _image = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "image", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String image{ set { _image = value; changed("image");} get { return _image; } }

				
					private System.String _deviceId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "deviceId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String deviceId{ set { _deviceId = value; changed("deviceId");} get { return _deviceId; } }

				
					private System.DateTime? _lastLoginDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "lastLoginDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? lastLoginDate{ set { _lastLoginDate = value; changed("lastLoginDate");} get { return _lastLoginDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.String _coucher = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "coucher", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String coucher{ set { _coucher = value; changed("coucher");} get { return _coucher; } }

				
					private System.String _certificateid = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "certificateid", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String certificateid{ set { _certificateid = value; changed("certificateid");} get { return _certificateid; } }

				
					private System.String _mail = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "mail", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String mail{ set { _mail = value; changed("mail");} get { return _mail; } }

				
					private System.String _postalcode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "postalcode", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String postalcode{ set { _postalcode = value; changed("postalcode");} get { return _postalcode; } }

				
					private System.String _unitname = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "unitname", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String unitname{ set { _unitname = value; changed("unitname");} get { return _unitname; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("Data_ImportExcelData")]
				public class Data_ImportExcelData : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _infoId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "infoId", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String infoId{ set { _infoId = value; changed("infoId");} get { return _infoId; } }

				
					private System.Int32 _DataSort = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "DataSort", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Int32 DataSort{ set { _DataSort = value; changed("DataSort");} get { return _DataSort; } }

				
					private System.String _F1 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "F1", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String F1{ set { _F1 = value; changed("F1");} get { return _F1; } }

				
					private System.String _F2 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "F2", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String F2{ set { _F2 = value; changed("F2");} get { return _F2; } }

				
					private System.String _F3 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "F3", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String F3{ set { _F3 = value; changed("F3");} get { return _F3; } }

				
					private System.String _F4 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "F4", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String F4{ set { _F4 = value; changed("F4");} get { return _F4; } }

				
					private System.String _F5 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "F5", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String F5{ set { _F5 = value; changed("F5");} get { return _F5; } }

				
					private System.String _F6 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "F6", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String F6{ set { _F6 = value; changed("F6");} get { return _F6; } }

				
					private System.String _F7 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "F7", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String F7{ set { _F7 = value; changed("F7");} get { return _F7; } }

				
					private System.String _F8 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "F8", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String F8{ set { _F8 = value; changed("F8");} get { return _F8; } }

				
					private System.String _F9 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "F9", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String F9{ set { _F9 = value; changed("F9");} get { return _F9; } }

				
					private System.String _F10 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "F10", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String F10{ set { _F10 = value; changed("F10");} get { return _F10; } }

				
					private System.String _F11 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "F11", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String F11{ set { _F11 = value; changed("F11");} get { return _F11; } }

				
					private System.String _F12 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "F12", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String F12{ set { _F12 = value; changed("F12");} get { return _F12; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("Data_ImportExcelInfo")]
				public class Data_ImportExcelInfo : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _FileName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "FileName", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String FileName{ set { _FileName = value; changed("FileName");} get { return _FileName; } }

				
					private System.String _KeyWork = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "KeyWork", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String KeyWork{ set { _KeyWork = value; changed("KeyWork");} get { return _KeyWork; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("domainArchiveContent")]
				public class domainArchiveContent : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _sort = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "sort", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String sort{ set { _sort = value; changed("sort");} get { return _sort; } }

				
					private System.String _Responsibility = "";
					/// <summary>
					/// 责任者
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Responsibility", FieldType = "nvarchar", FieldRemark = "责任者", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Responsibility{ set { _Responsibility = value; changed("Responsibility");} get { return _Responsibility; } }

				
					private System.String _typenumber = "";
					/// <summary>
					/// 文件编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "typenumber", FieldType = "nvarchar", FieldRemark = "文件编号", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String typenumber{ set { _typenumber = value; changed("typenumber");} get { return _typenumber; } }

				
					private System.String _volumeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volumeId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volumeId{ set { _volumeId = value; changed("volumeId");} get { return _volumeId; } }

				
					private System.String _codefile = "";
					/// <summary>
					/// 文件编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "codefile", FieldType = "varchar", FieldRemark = "文件编号", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String codefile{ set { _codefile = value; changed("codefile");} get { return _codefile; } }

				
					private System.String _subject = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subject", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subject{ set { _subject = value; changed("subject");} get { return _subject; } }

				
					private System.Int32 _pages = 0;
					/// <summary>
					/// 页数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "pages", FieldType = "int", FieldRemark = "页数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 pages{ set { _pages = value; changed("pages");} get { return _pages; } }

				
					private System.Int32 _count = 0;
					/// <summary>
					/// 页数（1至10）
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "count", FieldType = "int", FieldRemark = "页数（1至10）", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 count{ set { _count = value; changed("count");} get { return _count; } }

				
					private System.String _remark = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "remark", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String remark{ set { _remark = value; changed("remark");} get { return _remark; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 归档文件附件
				/// </summary>
				[DataEntityAttribute("domainArchivedAttachment")]
				public class domainArchivedAttachment : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _fileId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "fileId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String fileId{ set { _fileId = value; changed("fileId");} get { return _fileId; } }

				
					private System.String _volumeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volumeId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volumeId{ set { _volumeId = value; changed("volumeId");} get { return _volumeId; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.String _path = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "path", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String path{ set { _path = value; changed("path");} get { return _path; } }

				
					private System.Int32 _pageCount = 0;
					/// <summary>
					/// 页数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "pageCount", FieldType = "int", FieldRemark = "页数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 pageCount{ set { _pageCount = value; changed("pageCount");} get { return _pageCount; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 归档文件
				/// </summary>
				[DataEntityAttribute("domainArchiveFile")]
				public class domainArchiveFile : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 用作文件id
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "用作文件id", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.String _volumeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volumeId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volumeId{ set { _volumeId = value; changed("volumeId");} get { return _volumeId; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 题名
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "nvarchar", FieldRemark = "题名", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _subjects = "";
					/// <summary>
					/// 主题词
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjects", FieldType = "nvarchar", FieldRemark = "主题词", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjects{ set { _subjects = value; changed("subjects");} get { return _subjects; } }

				
					private System.DateTime? _limitedDate = null;
					/// <summary>
					/// 限办时间
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "limitedDate", FieldType = "date", FieldRemark = "限办时间", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? limitedDate{ set { _limitedDate = value; changed("limitedDate");} get { return _limitedDate; } }

				
					private System.String _type = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "type", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String type{ set { _type = value; changed("type");} get { return _type; } }

				
					private System.String _state = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.Int32 _pageCount = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "pageCount", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 pageCount{ set { _pageCount = value; changed("pageCount");} get { return _pageCount; } }

				
					private System.Int32 _partsCount = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "partsCount", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 partsCount{ set { _partsCount = value; changed("partsCount");} get { return _partsCount; } }

				
					private System.String _year = "";
					/// <summary>
					/// 年份
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "年份", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.String _organization = "";
					/// <summary>
					/// 机构问题
   
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organization", FieldType = "char", FieldRemark = "机构问题", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organization{ set { _organization = value; changed("organization");} get { return _organization; } }

				
					private System.String _foundsId = "";
					/// <summary>
					/// 全宗号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundsId", FieldType = "varchar", FieldRemark = "全宗号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundsId{ set { _foundsId = value; changed("foundsId");} get { return _foundsId; } }

				
					private System.String _securityId = "";
					/// <summary>
					/// 密级
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityId", FieldType = "char", FieldRemark = "密级", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityId{ set { _securityId = value; changed("securityId");} get { return _securityId; } }

				
					private System.String _storeTimeId = "";
					/// <summary>
					/// 保存期限ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "storeTimeId", FieldType = "char", FieldRemark = "保存期限ID", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String storeTimeId{ set { _storeTimeId = value; changed("storeTimeId");} get { return _storeTimeId; } }

				
					private System.DateTime? _receiveDate = null;
					/// <summary>
					/// 接收日期
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "receiveDate", FieldType = "datetime", FieldRemark = "接收日期", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? receiveDate{ set { _receiveDate = value; changed("receiveDate");} get { return _receiveDate; } }

				
					private System.String _comeFile = "";
					/// <summary>
					/// 来文机关
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "comeFile", FieldType = "varchar", FieldRemark = "来文机关", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String comeFile{ set { _comeFile = value; changed("comeFile");} get { return _comeFile; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.Boolean _IsBorrow = true;
					/// <summary>
					/// 是否借阅
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsBorrow", FieldType = "bit", FieldRemark = "是否借阅", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsBorrow{ set { _IsBorrow = value; changed("IsBorrow");} get { return _IsBorrow; } }

				}


				
				/// <summary>
				/// 归档文件
				/// </summary>
				[DataEntityAttribute("domainArchiveFileView")]
				public class domainArchiveFileView : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _subjects = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjects", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjects{ set { _subjects = value; changed("subjects");} get { return _subjects; } }

				
					private System.String _securityName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityName{ set { _securityName = value; changed("securityName");} get { return _securityName; } }

				
					private System.String _storeTime = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "storeTime", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String storeTime{ set { _storeTime = value; changed("storeTime");} get { return _storeTime; } }

				
					private System.Int32 _pageCount = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "pageCount", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 pageCount{ set { _pageCount = value; changed("pageCount");} get { return _pageCount; } }

				
					private System.Int32 _partsCount = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "partsCount", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 partsCount{ set { _partsCount = value; changed("partsCount");} get { return _partsCount; } }

				
					private System.String _comeFile = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "comeFile", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String comeFile{ set { _comeFile = value; changed("comeFile");} get { return _comeFile; } }

				
					private System.String _year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _receiveDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "receiveDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? receiveDate{ set { _receiveDate = value; changed("receiveDate");} get { return _receiveDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _type = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "type", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String type{ set { _type = value; changed("type");} get { return _type; } }

				
					private System.String _state = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.String _foundName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundName{ set { _foundName = value; changed("foundName");} get { return _foundName; } }

				
					private System.String _volumeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volumeId", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volumeId{ set { _volumeId = value; changed("volumeId");} get { return _volumeId; } }

				
					private System.String _organizName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organizName", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organizName{ set { _organizName = value; changed("organizName");} get { return _organizName; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.String _volumecodeid = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volumecodeid", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String volumecodeid{ set { _volumecodeid = value; changed("volumecodeid");} get { return _volumecodeid; } }

				
					private System.String _contectCode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "contectCode", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String contectCode{ set { _contectCode = value; changed("contectCode");} get { return _contectCode; } }

				}


				
				/// <summary>
				/// 历史记录表
				/// </summary>
				[DataEntityAttribute("domainArchiveHistory")]
				public class domainArchiveHistory : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _volumeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volumeId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volumeId{ set { _volumeId = value; changed("volumeId");} get { return _volumeId; } }

				
					private System.String _fileid = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "fileid", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String fileid{ set { _fileid = value; changed("fileid");} get { return _fileid; } }

				
					private System.String _type = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "type", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String type{ set { _type = value; changed("type");} get { return _type; } }

				
					private System.String _state = "";
					/// <summary>
					/// 处理状态
   
   
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "处理状态", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.String _commandId = "";
					/// <summary>
					/// 领导批示ID关联意见表
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "commandId", FieldType = "char", FieldRemark = "领导批示ID关联意见表", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String commandId{ set { _commandId = value; changed("commandId");} get { return _commandId; } }

				
					private System.String _historyId = "";
					/// <summary>
					/// 收发文流程中记录移交状态的historyId
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "historyId", FieldType = "char", FieldRemark = "收发文流程中记录移交状态的historyId", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String historyId{ set { _historyId = value; changed("historyId");} get { return _historyId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 附件
				/// </summary>
				[DataEntityAttribute("domainAttachment")]
				public class domainAttachment : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.String _path = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "path", FieldType = "varchar", FieldRemark = "", Length = 1000, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String path{ set { _path = value; changed("path");} get { return _path; } }

				
					private System.String _volume = "";
					/// <summary>
					/// 案卷号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volume", FieldType = "char", FieldRemark = "案卷号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volume{ set { _volume = value; changed("volume");} get { return _volume; } }

				
					private System.String _flowId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "flowId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String flowId{ set { _flowId = value; changed("flowId");} get { return _flowId; } }

				
					private System.String _pageCount = "";
					/// <summary>
					/// 页数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "pageCount", FieldType = "char", FieldRemark = "页数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String pageCount{ set { _pageCount = value; changed("pageCount");} get { return _pageCount; } }

				
					private System.String _partsCount = "";
					/// <summary>
					/// 份数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "partsCount", FieldType = "char", FieldRemark = "份数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String partsCount{ set { _partsCount = value; changed("partsCount");} get { return _partsCount; } }

				
					private System.Boolean _isRescan = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "isRescan", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean isRescan{ set { _isRescan = value; changed("isRescan");} get { return _isRescan; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 领导签字意见图层表
				/// </summary>
				[DataEntityAttribute("domainCommentImage")]
				public class domainCommentImage : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _attachId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "attachId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String attachId{ set { _attachId = value; changed("attachId");} get { return _attachId; } }

				
					private System.String _catalogId = "";
					/// <summary>
					/// 目录id
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "catalogId", FieldType = "char", FieldRemark = "目录id", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String catalogId{ set { _catalogId = value; changed("catalogId");} get { return _catalogId; } }

				
					private System.String _ocrId = "";
					/// <summary>
					/// OCR text id
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ocrId", FieldType = "char", FieldRemark = "OCR text id", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String ocrId{ set { _ocrId = value; changed("ocrId");} get { return _ocrId; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.String _img_path = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "img_path", FieldType = "varchar", FieldRemark = "", Length = 1000, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String img_path{ set { _img_path = value; changed("img_path");} get { return _img_path; } }

				
					private System.Int32 _page = 0;
					/// <summary>
					/// 页数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "page", FieldType = "int", FieldRemark = "页数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 page{ set { _page = value; changed("page");} get { return _page; } }

				
					private System.String _offsetX = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "offsetX", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String offsetX{ set { _offsetX = value; changed("offsetX");} get { return _offsetX; } }

				
					private System.String _offsetY = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "offsetY", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String offsetY{ set { _offsetY = value; changed("offsetY");} get { return _offsetY; } }

				
					private System.String _width = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "width", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String width{ set { _width = value; changed("width");} get { return _width; } }

				
					private System.String _height = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "height", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String height{ set { _height = value; changed("height");} get { return _height; } }

				
					private System.String _securityId = "";
					/// <summary>
					/// 密级
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityId", FieldType = "char", FieldRemark = "密级", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityId{ set { _securityId = value; changed("securityId");} get { return _securityId; } }

				
					private System.Int32 _sort = 0;
					/// <summary>
					/// 序号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "sort", FieldType = "int", FieldRemark = "序号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 sort{ set { _sort = value; changed("sort");} get { return _sort; } }

				
					private System.String _UserId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "UserId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String UserId{ set { _UserId = value; changed("UserId");} get { return _UserId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.Boolean _ocred = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ocred", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Boolean ocred{ set { _ocred = value; changed("ocred");} get { return _ocred; } }

				
					private System.Boolean _luceneIndexed = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "luceneIndexed", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Boolean luceneIndexed{ set { _luceneIndexed = value; changed("luceneIndexed");} get { return _luceneIndexed; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("domainComparisions_files")]
				public class domainComparisions_files : Entity
				{
					
			
					private System.Int32 _id = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = true, AllowNull = false)]
					public System.Int32 id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _ArchivefileId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ArchivefileId", FieldType = "nchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String ArchivefileId{ set { _ArchivefileId = value; changed("ArchivefileId");} get { return _ArchivefileId; } }

				
					private System.String _ScanningFileId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "ScanningFileId", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String ScanningFileId{ set { _ScanningFileId = value; changed("ScanningFileId");} get { return _ScanningFileId; } }

				
					private System.DateTime? _createtime = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createtime", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createtime{ set { _createtime = value; changed("createtime");} get { return _createtime; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("domainComparisons_volumeids")]
				public class domainComparisons_volumeids : Entity
				{
					
			
					private System.Int32 _id = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = true, AllowNull = false)]
					public System.Int32 id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _volumeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volumeId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volumeId{ set { _volumeId = value; changed("volumeId");} get { return _volumeId; } }

				
					private System.String _scanningId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "scanningId", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String scanningId{ set { _scanningId = value; changed("scanningId");} get { return _scanningId; } }

				
					private System.DateTime? _createdtime = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createdtime", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createdtime{ set { _createdtime = value; changed("createdtime");} get { return _createdtime; } }

				}


				
				/// <summary>
				/// 文件列表
				/// </summary>
				[DataEntityAttribute("domainFile")]
				public class domainFile : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.String _typenumber = "";
					/// <summary>
					/// 文号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "typenumber", FieldType = "varchar", FieldRemark = "文号", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String typenumber{ set { _typenumber = value; changed("typenumber");} get { return _typenumber; } }

				
					private System.String _volume = "";
					/// <summary>
					/// 案卷号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volume", FieldType = "varchar", FieldRemark = "案卷号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volume{ set { _volume = value; changed("volume");} get { return _volume; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 题名
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "varchar", FieldRemark = "题名", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _subjects = "";
					/// <summary>
					/// 主题词
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjects", FieldType = "varchar", FieldRemark = "主题词", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjects{ set { _subjects = value; changed("subjects");} get { return _subjects; } }

				
					private System.DateTime? _limitedDate = null;
					/// <summary>
					/// 限办时间
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "limitedDate", FieldType = "date", FieldRemark = "限办时间", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? limitedDate{ set { _limitedDate = value; changed("limitedDate");} get { return _limitedDate; } }

				
					private System.String _year = "";
					/// <summary>
					/// 年份
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "年份", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.String _organizationId = "";
					/// <summary>
					/// 机构问题
   
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organizationId", FieldType = "char", FieldRemark = "机构问题", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organizationId{ set { _organizationId = value; changed("organizationId");} get { return _organizationId; } }

				
					private System.String _foundsId = "";
					/// <summary>
					/// 全宗号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundsId", FieldType = "varchar", FieldRemark = "全宗号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundsId{ set { _foundsId = value; changed("foundsId");} get { return _foundsId; } }

				
					private System.String _securityId = "";
					/// <summary>
					/// 密级
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityId", FieldType = "char", FieldRemark = "密级", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityId{ set { _securityId = value; changed("securityId");} get { return _securityId; } }

				
					private System.String _storeTimeId = "";
					/// <summary>
					/// 保存期限ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "storeTimeId", FieldType = "char", FieldRemark = "保存期限ID", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String storeTimeId{ set { _storeTimeId = value; changed("storeTimeId");} get { return _storeTimeId; } }

				
					private System.String _attachmentId = "";
					/// <summary>
					/// 附件
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "attachmentId", FieldType = "char", FieldRemark = "附件", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String attachmentId{ set { _attachmentId = value; changed("attachmentId");} get { return _attachmentId; } }

				
					private System.DateTime? _receiveDate = null;
					/// <summary>
					/// 接收日期
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "receiveDate", FieldType = "datetime", FieldRemark = "接收日期", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? receiveDate{ set { _receiveDate = value; changed("receiveDate");} get { return _receiveDate; } }

				
					private System.String _comeFile = "";
					/// <summary>
					/// 来文机关
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "comeFile", FieldType = "varchar", FieldRemark = "来文机关", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String comeFile{ set { _comeFile = value; changed("comeFile");} get { return _comeFile; } }

				
					private System.String _preFileId = "";
					/// <summary>
					/// 预归档号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "preFileId", FieldType = "char", FieldRemark = "预归档号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String preFileId{ set { _preFileId = value; changed("preFileId");} get { return _preFileId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.String _departmentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "departmentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String departmentId{ set { _departmentId = value; changed("departmentId");} get { return _departmentId; } }

				}


				
				/// <summary>
				/// 文件流转
				/// </summary>
				[DataEntityAttribute("domainFileFlow")]
				public class domainFileFlow : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _fileid = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "fileid", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String fileid{ set { _fileid = value; changed("fileid");} get { return _fileid; } }

				
					private System.String _stateFather = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "stateFather", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String stateFather{ set { _stateFather = value; changed("stateFather");} get { return _stateFather; } }

				
					private System.String _state = "";
					/// <summary>
					/// 处理状态
   
   
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "处理状态", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 历史记录表
				/// </summary>
				[DataEntityAttribute("domainFileHistory")]
				public class domainFileHistory : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _flowId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "flowId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String flowId{ set { _flowId = value; changed("flowId");} get { return _flowId; } }

				
					private System.String _opinionId = "";
					/// <summary>
					/// 处理方式：传阅、承办、阅签
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "opinionId", FieldType = "varchar", FieldRemark = "处理方式：传阅、承办、阅签", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String opinionId{ set { _opinionId = value; changed("opinionId");} get { return _opinionId; } }

				
					private System.String _type = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "type", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String type{ set { _type = value; changed("type");} get { return _type; } }

				
					private System.String _state = "";
					/// <summary>
					/// 处理状态
   
   
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "处理状态", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.String _filingFileId = "";
					/// <summary>
					/// 归档文件
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filingFileId", FieldType = "char", FieldRemark = "归档文件", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filingFileId{ set { _filingFileId = value; changed("filingFileId");} get { return _filingFileId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.Boolean _Isdisplay = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Isdisplay", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean Isdisplay{ set { _Isdisplay = value; changed("Isdisplay");} get { return _Isdisplay; } }

				}


				
				/// <summary>
				/// 收文列表
				/// </summary>
				[DataEntityAttribute("domainFileReceive")]
				public class domainFileReceive : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 题名
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "varchar", FieldRemark = "题名", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _subjects = "";
					/// <summary>
					/// 主题词
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjects", FieldType = "varchar", FieldRemark = "主题词", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjects{ set { _subjects = value; changed("subjects");} get { return _subjects; } }

				
					private System.DateTime? _limitedDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "limitedDate", FieldType = "date", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? limitedDate{ set { _limitedDate = value; changed("limitedDate");} get { return _limitedDate; } }

				
					private System.String _year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.String _organization = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organization", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organization{ set { _organization = value; changed("organization");} get { return _organization; } }

				
					private System.String _foundsId = "";
					/// <summary>
					/// 全宗号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundsId", FieldType = "varchar", FieldRemark = "全宗号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundsId{ set { _foundsId = value; changed("foundsId");} get { return _foundsId; } }

				
					private System.String _securityId = "";
					/// <summary>
					/// 密级
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityId", FieldType = "char", FieldRemark = "密级", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityId{ set { _securityId = value; changed("securityId");} get { return _securityId; } }

				
					private System.String _storeTimeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "storeTimeId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String storeTimeId{ set { _storeTimeId = value; changed("storeTimeId");} get { return _storeTimeId; } }

				
					private System.String _attachmentId = "";
					/// <summary>
					/// 附件
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "attachmentId", FieldType = "char", FieldRemark = "附件", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String attachmentId{ set { _attachmentId = value; changed("attachmentId");} get { return _attachmentId; } }

				
					private System.Int32 _pageCount = 0;
					/// <summary>
					/// 页数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "pageCount", FieldType = "int", FieldRemark = "页数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 pageCount{ set { _pageCount = value; changed("pageCount");} get { return _pageCount; } }

				
					private System.Int32 _partsCount = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "partsCount", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 partsCount{ set { _partsCount = value; changed("partsCount");} get { return _partsCount; } }

				
					private System.String _leadership = "";
					/// <summary>
					/// 领导批示
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "leadership", FieldType = "varchar", FieldRemark = "领导批示", Length = 300, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String leadership{ set { _leadership = value; changed("leadership");} get { return _leadership; } }

				
					private System.DateTime? _receiveDate = null;
					/// <summary>
					/// 接收日期
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "receiveDate", FieldType = "datetime", FieldRemark = "接收日期", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? receiveDate{ set { _receiveDate = value; changed("receiveDate");} get { return _receiveDate; } }

				
					private System.String _office = "";
					/// <summary>
					/// 来文机关
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "office", FieldType = "varchar", FieldRemark = "来文机关", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String office{ set { _office = value; changed("office");} get { return _office; } }

				
					private System.String _disposeMethod = "";
					/// <summary>
					/// 处理方式
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "disposeMethod", FieldType = "char", FieldRemark = "处理方式", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String disposeMethod{ set { _disposeMethod = value; changed("disposeMethod");} get { return _disposeMethod; } }

				
					private System.String _state = "";
					/// <summary>
					/// 处理状态
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "处理状态", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.String _disposeResult = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "disposeResult", FieldType = "varchar", FieldRemark = "", Length = 300, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String disposeResult{ set { _disposeResult = value; changed("disposeResult");} get { return _disposeResult; } }

				
					private System.String _superviseOption = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "superviseOption", FieldType = "varchar", FieldRemark = "", Length = 300, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String superviseOption{ set { _superviseOption = value; changed("superviseOption");} get { return _superviseOption; } }

				
					private System.DateTime? _superviseDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "superviseDate", FieldType = "date", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? superviseDate{ set { _superviseDate = value; changed("superviseDate");} get { return _superviseDate; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 发文列表
				/// </summary>
				[DataEntityAttribute("domainFileSend")]
				public class domainFileSend : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 题名
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "varchar", FieldRemark = "题名", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _subjects = "";
					/// <summary>
					/// 主题词
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjects", FieldType = "varchar", FieldRemark = "主题词", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjects{ set { _subjects = value; changed("subjects");} get { return _subjects; } }

				
					private System.DateTime? _limitedDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "limitedDate", FieldType = "date", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? limitedDate{ set { _limitedDate = value; changed("limitedDate");} get { return _limitedDate; } }

				
					private System.String _year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.String _organization = "";
					/// <summary>
					/// 机构问题
   
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organization", FieldType = "char", FieldRemark = "机构问题", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organization{ set { _organization = value; changed("organization");} get { return _organization; } }

				
					private System.String _foundsId = "";
					/// <summary>
					/// 全宗号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundsId", FieldType = "varchar", FieldRemark = "全宗号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundsId{ set { _foundsId = value; changed("foundsId");} get { return _foundsId; } }

				
					private System.String _securityId = "";
					/// <summary>
					/// 密级
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityId", FieldType = "char", FieldRemark = "密级", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityId{ set { _securityId = value; changed("securityId");} get { return _securityId; } }

				
					private System.String _storeTimeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "storeTimeId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String storeTimeId{ set { _storeTimeId = value; changed("storeTimeId");} get { return _storeTimeId; } }

				
					private System.String _attachmentId = "";
					/// <summary>
					/// 附件
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "attachmentId", FieldType = "char", FieldRemark = "附件", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String attachmentId{ set { _attachmentId = value; changed("attachmentId");} get { return _attachmentId; } }

				
					private System.Int32 _pageCount = 0;
					/// <summary>
					/// 页数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "pageCount", FieldType = "int", FieldRemark = "页数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 pageCount{ set { _pageCount = value; changed("pageCount");} get { return _pageCount; } }

				
					private System.Int32 _partsCount = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "partsCount", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 partsCount{ set { _partsCount = value; changed("partsCount");} get { return _partsCount; } }

				
					private System.String _leadership = "";
					/// <summary>
					/// 领导批示
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "leadership", FieldType = "varchar", FieldRemark = "领导批示", Length = 300, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String leadership{ set { _leadership = value; changed("leadership");} get { return _leadership; } }

				
					private System.DateTime? _receiveDate = null;
					/// <summary>
					/// 接收日期
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "receiveDate", FieldType = "datetime", FieldRemark = "接收日期", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? receiveDate{ set { _receiveDate = value; changed("receiveDate");} get { return _receiveDate; } }

				
					private System.String _office = "";
					/// <summary>
					/// 来文机关
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "office", FieldType = "varchar", FieldRemark = "来文机关", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String office{ set { _office = value; changed("office");} get { return _office; } }

				
					private System.String _disposeMethod = "";
					/// <summary>
					/// 处理方式
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "disposeMethod", FieldType = "char", FieldRemark = "处理方式", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String disposeMethod{ set { _disposeMethod = value; changed("disposeMethod");} get { return _disposeMethod; } }

				
					private System.String _state = "";
					/// <summary>
					/// 处理状态
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "处理状态", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.String _disposeResult = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "disposeResult", FieldType = "varchar", FieldRemark = "", Length = 300, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String disposeResult{ set { _disposeResult = value; changed("disposeResult");} get { return _disposeResult; } }

				
					private System.String _superviseOption = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "superviseOption", FieldType = "varchar", FieldRemark = "", Length = 300, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String superviseOption{ set { _superviseOption = value; changed("superviseOption");} get { return _superviseOption; } }

				
					private System.DateTime? _superviseDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "superviseDate", FieldType = "date", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? superviseDate{ set { _superviseDate = value; changed("superviseDate");} get { return _superviseDate; } }

				
					private System.String _preFileId = "";
					/// <summary>
					/// 预归档号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "preFileId", FieldType = "char", FieldRemark = "预归档号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String preFileId{ set { _preFileId = value; changed("preFileId");} get { return _preFileId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("domainOCRText")]
				public class domainOCRText : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _imageId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "imageId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String imageId{ set { _imageId = value; changed("imageId");} get { return _imageId; } }

				
					private System.String _text = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "text", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String text{ set { _text = value; changed("text");} get { return _text; } }

				
					private System.Boolean _luceneIndexed = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "luceneIndexed", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Boolean luceneIndexed{ set { _luceneIndexed = value; changed("luceneIndexed");} get { return _luceneIndexed; } }

				
					private System.Boolean _isDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "isDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean isDelete{ set { _isDelete = value; changed("isDelete");} get { return _isDelete; } }

				
					private System.DateTime? _createdate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createdate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createdate{ set { _createdate = value; changed("createdate");} get { return _createdate; } }

				
					private System.DateTime? _modifydate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifydate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifydate{ set { _modifydate = value; changed("modifydate");} get { return _modifydate; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("domainVolume")]
				public class domainVolume : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _contectCode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "contectCode", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String contectCode{ set { _contectCode = value; changed("contectCode");} get { return _contectCode; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.String _organizationParent = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organizationParent", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organizationParent{ set { _organizationParent = value; changed("organizationParent");} get { return _organizationParent; } }

				
					private System.String _organization = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organization", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organization{ set { _organization = value; changed("organization");} get { return _organization; } }

				
					private System.String _foundsId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundsId", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundsId{ set { _foundsId = value; changed("foundsId");} get { return _foundsId; } }

				
					private System.String _securityId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityId{ set { _securityId = value; changed("securityId");} get { return _securityId; } }

				
					private System.String _storeTimeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "storeTimeId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String storeTimeId{ set { _storeTimeId = value; changed("storeTimeId");} get { return _storeTimeId; } }

				
					private System.String _discription = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "discription", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String discription{ set { _discription = value; changed("discription");} get { return _discription; } }

				
					private System.DateTime? _dateStart = null;
					/// <summary>
					/// 案卷表起始时间
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "dateStart", FieldType = "date", FieldRemark = "案卷表起始时间", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? dateStart{ set { _dateStart = value; changed("dateStart");} get { return _dateStart; } }

				
					private System.DateTime? _dateEnd = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "dateEnd", FieldType = "date", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? dateEnd{ set { _dateEnd = value; changed("dateEnd");} get { return _dateEnd; } }

				
					private System.String _state = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.String _fatherstate = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "fatherstate", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String fatherstate{ set { _fatherstate = value; changed("fatherstate");} get { return _fatherstate; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("Fileview")]
				public class Fileview : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _subjects = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjects", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjects{ set { _subjects = value; changed("subjects");} get { return _subjects; } }

				
					private System.String _organizName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organizName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organizName{ set { _organizName = value; changed("organizName");} get { return _organizName; } }

				
					private System.String _foundName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundName{ set { _foundName = value; changed("foundName");} get { return _foundName; } }

				
					private System.String _Security = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Security", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Security{ set { _Security = value; changed("Security");} get { return _Security; } }

				
					private System.String _StoreTime = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "StoreTime", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String StoreTime{ set { _StoreTime = value; changed("StoreTime");} get { return _StoreTime; } }

				
					private System.String _state = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.DateTime? _limitedDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "limitedDate", FieldType = "date", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? limitedDate{ set { _limitedDate = value; changed("limitedDate");} get { return _limitedDate; } }

				
					private System.String _year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.String _comeFile = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "comeFile", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String comeFile{ set { _comeFile = value; changed("comeFile");} get { return _comeFile; } }

				
					private System.DateTime? _receiveDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "receiveDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? receiveDate{ set { _receiveDate = value; changed("receiveDate");} get { return _receiveDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _stateid = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "stateid", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String stateid{ set { _stateid = value; changed("stateid");} get { return _stateid; } }

				
					private System.String _type = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "type", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String type{ set { _type = value; changed("type");} get { return _type; } }

				
					private System.String _typeid = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "typeid", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String typeid{ set { _typeid = value; changed("typeid");} get { return _typeid; } }

				
					private System.String _securityid = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityid", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String securityid{ set { _securityid = value; changed("securityid");} get { return _securityid; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("ImageView")]
				public class ImageView : Entity
				{
					
			
					private System.String _contectCode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "contectCode", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String contectCode{ set { _contectCode = value; changed("contectCode");} get { return _contectCode; } }

				
					private System.String _year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.String _organizName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organizName", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organizName{ set { _organizName = value; changed("organizName");} get { return _organizName; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.String _parentOrgName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parentOrgName", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String parentOrgName{ set { _parentOrgName = value; changed("parentOrgName");} get { return _parentOrgName; } }

				
					private System.String _parentOrgDesc = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parentOrgDesc", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String parentOrgDesc{ set { _parentOrgDesc = value; changed("parentOrgDesc");} get { return _parentOrgDesc; } }

				
					private System.String _img_path = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "img_path", FieldType = "varchar", FieldRemark = "", Length = 1000, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String img_path{ set { _img_path = value; changed("img_path");} get { return _img_path; } }

				
					private System.Int32 _sort = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "sort", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 sort{ set { _sort = value; changed("sort");} get { return _sort; } }

				
					private System.String _width = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "width", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String width{ set { _width = value; changed("width");} get { return _width; } }

				
					private System.String _height = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "height", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String height{ set { _height = value; changed("height");} get { return _height; } }

				
					private System.String _imageId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "imageId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String imageId{ set { _imageId = value; changed("imageId");} get { return _imageId; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _Responsibility = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Responsibility", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Responsibility{ set { _Responsibility = value; changed("Responsibility");} get { return _Responsibility; } }

				
					private System.String _typenumber = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "typenumber", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String typenumber{ set { _typenumber = value; changed("typenumber");} get { return _typenumber; } }

				
					private System.String _subject = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subject", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subject{ set { _subject = value; changed("subject");} get { return _subject; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("logLogins")]
				public class logLogins : Entity
				{
					
			
					private System.Int32 _id = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = true, AllowNull = false)]
					public System.Int32 id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _userId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "userId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String userId{ set { _userId = value; changed("userId");} get { return _userId; } }

				
					private System.String _window = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "window", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String window{ set { _window = value; changed("window");} get { return _window; } }

				
					private System.String _button = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "button", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String button{ set { _button = value; changed("button");} get { return _button; } }

				
					private System.String _archiveId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "archiveId", FieldType = "char", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String archiveId{ set { _archiveId = value; changed("archiveId");} get { return _archiveId; } }

				
					private System.String _operationId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "operationId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String operationId{ set { _operationId = value; changed("operationId");} get { return _operationId; } }

				
					private System.DateTime? _operdate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "operdate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? operdate{ set { _operdate = value; changed("operdate");} get { return _operdate; } }

				
					private System.DateTime? _createdate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createdate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createdate{ set { _createdate = value; changed("createdate");} get { return _createdate; } }

				
					private System.DateTime? _modifydate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifydate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifydate{ set { _modifydate = value; changed("modifydate");} get { return _modifydate; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("logOperation")]
				public class logOperation : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _objectId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "objectId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String objectId{ set { _objectId = value; changed("objectId");} get { return _objectId; } }

				
					private System.String _operationId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "operationId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String operationId{ set { _operationId = value; changed("operationId");} get { return _operationId; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.String _userId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "userId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String userId{ set { _userId = value; changed("userId");} get { return _userId; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("MobileAttachment")]
				public class MobileAttachment : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.String _attachId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "attachId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String attachId{ set { _attachId = value; changed("attachId");} get { return _attachId; } }

				
					private System.String _path = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "path", FieldType = "varchar", FieldRemark = "", Length = 1000, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String path{ set { _path = value; changed("path");} get { return _path; } }

				
					private System.String _pageCount = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "pageCount", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String pageCount{ set { _pageCount = value; changed("pageCount");} get { return _pageCount; } }

				
					private System.String _partsCount = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "partsCount", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String partsCount{ set { _partsCount = value; changed("partsCount");} get { return _partsCount; } }

				
					private System.Boolean _isRescan = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "isRescan", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean isRescan{ set { _isRescan = value; changed("isRescan");} get { return _isRescan; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.String _year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("MobileFiles")]
				public class MobileFiles : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.String _typenumber = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "typenumber", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String typenumber{ set { _typenumber = value; changed("typenumber");} get { return _typenumber; } }

				
					private System.String _volume = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volume", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volume{ set { _volume = value; changed("volume");} get { return _volume; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _subjects = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjects", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjects{ set { _subjects = value; changed("subjects");} get { return _subjects; } }

				
					private System.DateTime? _limitedDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "limitedDate", FieldType = "date", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? limitedDate{ set { _limitedDate = value; changed("limitedDate");} get { return _limitedDate; } }

				
					private System.String _year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.String _organizationId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organizationId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organizationId{ set { _organizationId = value; changed("organizationId");} get { return _organizationId; } }

				
					private System.String _foundsId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundsId", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundsId{ set { _foundsId = value; changed("foundsId");} get { return _foundsId; } }

				
					private System.String _securityId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityId{ set { _securityId = value; changed("securityId");} get { return _securityId; } }

				
					private System.String _storeTimeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "storeTimeId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String storeTimeId{ set { _storeTimeId = value; changed("storeTimeId");} get { return _storeTimeId; } }

				
					private System.String _attachmentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "attachmentId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String attachmentId{ set { _attachmentId = value; changed("attachmentId");} get { return _attachmentId; } }

				
					private System.DateTime? _receiveDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "receiveDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? receiveDate{ set { _receiveDate = value; changed("receiveDate");} get { return _receiveDate; } }

				
					private System.String _comeFile = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "comeFile", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String comeFile{ set { _comeFile = value; changed("comeFile");} get { return _comeFile; } }

				
					private System.String _preFileId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "preFileId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String preFileId{ set { _preFileId = value; changed("preFileId");} get { return _preFileId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.String _departmentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "departmentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String departmentId{ set { _departmentId = value; changed("departmentId");} get { return _departmentId; } }

				
					private System.String _userId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "userId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String userId{ set { _userId = value; changed("userId");} get { return _userId; } }

				
					private System.DateTime? _Expr1 = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Expr1", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? Expr1{ set { _Expr1 = value; changed("Expr1");} get { return _Expr1; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("NewFileView")]
				public class NewFileView : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _subjects = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjects", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjects{ set { _subjects = value; changed("subjects");} get { return _subjects; } }

				
					private System.String _organizName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organizName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organizName{ set { _organizName = value; changed("organizName");} get { return _organizName; } }

				
					private System.String _foundName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundName{ set { _foundName = value; changed("foundName");} get { return _foundName; } }

				
					private System.String _securityName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityName{ set { _securityName = value; changed("securityName");} get { return _securityName; } }

				
					private System.String _storeTime = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "storeTime", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String storeTime{ set { _storeTime = value; changed("storeTime");} get { return _storeTime; } }

				
					private System.String _fatherStateId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "fatherStateId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String fatherStateId{ set { _fatherStateId = value; changed("fatherStateId");} get { return _fatherStateId; } }

				
					private System.String _stateId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "stateId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String stateId{ set { _stateId = value; changed("stateId");} get { return _stateId; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				}


				
				/// <summary>
				/// 权限页面角色关系表
				/// </summary>
				[DataEntityAttribute("notification")]
				public class notification : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _actionId = "";
					/// <summary>
					/// 权限页面ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "actionId", FieldType = "char", FieldRemark = "权限页面ID", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String actionId{ set { _actionId = value; changed("actionId");} get { return _actionId; } }

				
					private System.String _userid = "";
					/// <summary>
					/// 人员ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "userid", FieldType = "char", FieldRemark = "人员ID", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String userid{ set { _userid = value; changed("userid");} get { return _userid; } }

				
					private System.String _tableName = "";
					/// <summary>
					/// 表名
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "tableName", FieldType = "varchar", FieldRemark = "表名", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String tableName{ set { _tableName = value; changed("tableName");} get { return _tableName; } }

				
					private System.String _type = "";
					/// <summary>
					/// 父状态
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "type", FieldType = "char", FieldRemark = "父状态", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String type{ set { _type = value; changed("type");} get { return _type; } }

				
					private System.String _state = "";
					/// <summary>
					/// 状态
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "状态", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.String _Column_12 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Column_12", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String Column_12{ set { _Column_12 = value; changed("Column_12");} get { return _Column_12; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("positionView")]
				public class positionView : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _type = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "type", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String type{ set { _type = value; changed("type");} get { return _type; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _subjects = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjects", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjects{ set { _subjects = value; changed("subjects");} get { return _subjects; } }

				
					private System.String _securityName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityName{ set { _securityName = value; changed("securityName");} get { return _securityName; } }

				
					private System.String _storetime = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "storetime", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String storetime{ set { _storetime = value; changed("storetime");} get { return _storetime; } }

				
					private System.String _year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.String _foundName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundName{ set { _foundName = value; changed("foundName");} get { return _foundName; } }

				
					private System.String _library = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "library", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String library{ set { _library = value; changed("library");} get { return _library; } }

				
					private System.String _cabinet = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "cabinet", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String cabinet{ set { _cabinet = value; changed("cabinet");} get { return _cabinet; } }

				
					private System.Int32 _lay = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "lay", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 lay{ set { _lay = value; changed("lay");} get { return _lay; } }

				
					private System.Int32 _caseCount = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "caseCount", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 caseCount{ set { _caseCount = value; changed("caseCount");} get { return _caseCount; } }

				
					private System.String _box = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "box", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String box{ set { _box = value; changed("box");} get { return _box; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.String _VolumeName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "VolumeName", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String VolumeName{ set { _VolumeName = value; changed("VolumeName");} get { return _VolumeName; } }

				
					private System.String _stateName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "stateName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String stateName{ set { _stateName = value; changed("stateName");} get { return _stateName; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.String _state = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.String _organizName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organizName", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organizName{ set { _organizName = value; changed("organizName");} get { return _organizName; } }

				
					private System.Boolean _IsBorrow = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsBorrow", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsBorrow{ set { _IsBorrow = value; changed("IsBorrow");} get { return _IsBorrow; } }

				
					private System.String _cabinetId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "cabinetId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String cabinetId{ set { _cabinetId = value; changed("cabinetId");} get { return _cabinetId; } }

				
					private System.String _volume = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volume", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volume{ set { _volume = value; changed("volume");} get { return _volume; } }

				
					private System.String _contectCode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "contectCode", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String contectCode{ set { _contectCode = value; changed("contectCode");} get { return _contectCode; } }

				
					private System.String _organization = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organization", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organization{ set { _organization = value; changed("organization");} get { return _organization; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				}


				
				/// <summary>
				/// 权限页面角色关系表
				/// </summary>
				[DataEntityAttribute("reActionRoles")]
				public class reActionRoles : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _actionId = "";
					/// <summary>
					/// 权限页面ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "actionId", FieldType = "char", FieldRemark = "权限页面ID", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String actionId{ set { _actionId = value; changed("actionId");} get { return _actionId; } }

				
					private System.String _roleId = "";
					/// <summary>
					/// 角色ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "roleId", FieldType = "char", FieldRemark = "角色ID", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String roleId{ set { _roleId = value; changed("roleId");} get { return _roleId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 权限页面角色关系表
				/// </summary>
				[DataEntityAttribute("reActionUser")]
				public class reActionUser : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _actionId = "";
					/// <summary>
					/// 权限页面ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "actionId", FieldType = "char", FieldRemark = "权限页面ID", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String actionId{ set { _actionId = value; changed("actionId");} get { return _actionId; } }

				
					private System.String _userid = "";
					/// <summary>
					/// 人员ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "userid", FieldType = "char", FieldRemark = "人员ID", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String userid{ set { _userid = value; changed("userid");} get { return _userid; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 报损单
				/// </summary>
				[DataEntityAttribute("reBreakageFile")]
				public class reBreakageFile : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _fileId = "";
					/// <summary>
					/// 文件ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "fileId", FieldType = "char", FieldRemark = "文件ID", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String fileId{ set { _fileId = value; changed("fileId");} get { return _fileId; } }

				
					private System.String _description = "";
					/// <summary>
					/// 报损意见
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "varchar", FieldRemark = "报损意见", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.DateTime? _partsCount = null;
					/// <summary>
					/// 份数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "partsCount", FieldType = "date", FieldRemark = "份数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? partsCount{ set { _partsCount = value; changed("partsCount");} get { return _partsCount; } }

				
					private System.String _approver = "";
					/// <summary>
					/// 报损人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "approver", FieldType = "char", FieldRemark = "报损人", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String approver{ set { _approver = value; changed("approver");} get { return _approver; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 领导批示关系表
				/// </summary>
				[DataEntityAttribute("reCommandFile")]
				public class reCommandFile : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _flowId = "";
					/// <summary>
					/// 文件ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "flowId", FieldType = "char", FieldRemark = "文件ID", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String flowId{ set { _flowId = value; changed("flowId");} get { return _flowId; } }

				
					private System.String _userId = "";
					/// <summary>
					/// 领导ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "userId", FieldType = "char", FieldRemark = "领导ID", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String userId{ set { _userId = value; changed("userId");} get { return _userId; } }

				
					private System.String _path = "";
					/// <summary>
					/// 批示意见
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "path", FieldType = "varchar", FieldRemark = "批示意见", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String path{ set { _path = value; changed("path");} get { return _path; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.DateTime? _createtime = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createtime", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createtime{ set { _createtime = value; changed("createtime");} get { return _createtime; } }

				
					private System.DateTime? _modifydate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifydate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifydate{ set { _modifydate = value; changed("modifydate");} get { return _modifydate; } }

				}


				
				/// <summary>
				/// 部门机构关系表
				/// </summary>
				[DataEntityAttribute("reDepartOrgniz")]
				public class reDepartOrgniz : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _departId = "";
					/// <summary>
					/// 部门ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "departId", FieldType = "char", FieldRemark = "部门ID", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String departId{ set { _departId = value; changed("departId");} get { return _departId; } }

				
					private System.String _orgnizeId = "";
					/// <summary>
					/// 机构ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "orgnizeId", FieldType = "char", FieldRemark = "机构ID", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String orgnizeId{ set { _orgnizeId = value; changed("orgnizeId");} get { return _orgnizeId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 销毁单
				/// </summary>
				[DataEntityAttribute("reDestroyFile")]
				public class reDestroyFile : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _flowId = "";
					/// <summary>
					/// 文件ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "flowId", FieldType = "char", FieldRemark = "文件ID", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String flowId{ set { _flowId = value; changed("flowId");} get { return _flowId; } }

				
					private System.String _reason = "";
					/// <summary>
					/// 销毁原因
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "reason", FieldType = "varchar", FieldRemark = "销毁原因", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String reason{ set { _reason = value; changed("reason");} get { return _reason; } }

				
					private System.DateTime? _partsCount = null;
					/// <summary>
					/// 份数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "partsCount", FieldType = "date", FieldRemark = "份数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? partsCount{ set { _partsCount = value; changed("partsCount");} get { return _partsCount; } }

				
					private System.String _destroyWay = "";
					/// <summary>
					/// 销毁方式
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "destroyWay", FieldType = "varchar", FieldRemark = "销毁方式", Length = 200, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String destroyWay{ set { _destroyWay = value; changed("destroyWay");} get { return _destroyWay; } }

				
					private System.String _approver = "";
					/// <summary>
					/// 批准人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "approver", FieldType = "char", FieldRemark = "批准人", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String approver{ set { _approver = value; changed("approver");} get { return _approver; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 处理结果文件关系表
				/// </summary>
				[DataEntityAttribute("reDisposeFile")]
				public class reDisposeFile : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _flowId = "";
					/// <summary>
					/// 流程ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "flowId", FieldType = "char", FieldRemark = "流程ID", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String flowId{ set { _flowId = value; changed("flowId");} get { return _flowId; } }

				
					private System.String _disposeRoleId = "";
					/// <summary>
					/// 角色（拟稿人，核稿人。。。）
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "disposeRoleId", FieldType = "char", FieldRemark = "角色（拟稿人，核稿人。。。）", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String disposeRoleId{ set { _disposeRoleId = value; changed("disposeRoleId");} get { return _disposeRoleId; } }

				
					private System.String _disposeUser = "";
					/// <summary>
					/// 处理人员，区分处理角色，主要适用拟稿人，核稿人等角色和人员区分。
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "disposeUser", FieldType = "char", FieldRemark = "处理人员，区分处理角色，主要适用拟稿人，核稿人等角色和人员区分。", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String disposeUser{ set { _disposeUser = value; changed("disposeUser");} get { return _disposeUser; } }

				
					private System.String _disposeDepartmentId = "";
					/// <summary>
					/// 处理部门
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "disposeDepartmentId", FieldType = "char", FieldRemark = "处理部门", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String disposeDepartmentId{ set { _disposeDepartmentId = value; changed("disposeDepartmentId");} get { return _disposeDepartmentId; } }

				
					private System.String _opinion = "";
					/// <summary>
					/// 执行意见
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "opinion", FieldType = "varchar", FieldRemark = "执行意见", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String opinion{ set { _opinion = value; changed("opinion");} get { return _opinion; } }

				
					private System.String _imagePathId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "imagePathId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String imagePathId{ set { _imagePathId = value; changed("imagePathId");} get { return _imagePathId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// bs文件查看关系表
				/// </summary>
				[DataEntityAttribute("reFile_bs")]
				public class reFile_bs : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 归档号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "归档号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 文件申请查看借阅登记表
				/// </summary>
				[DataEntityAttribute("reFileApplication")]
				public class reFileApplication : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 归档号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "归档号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.String _proposer = "";
					/// <summary>
					/// 申请人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "proposer", FieldType = "char", FieldRemark = "申请人", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String proposer{ set { _proposer = value; changed("proposer");} get { return _proposer; } }

				
					private System.DateTime? _limitedDate = null;
					/// <summary>
					/// 归还期限
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "limitedDate", FieldType = "datetime", FieldRemark = "归还期限", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? limitedDate{ set { _limitedDate = value; changed("limitedDate");} get { return _limitedDate; } }

				
					private System.String _stateId = "";
					/// <summary>
					/// 状态
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "stateId", FieldType = "char", FieldRemark = "状态", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String stateId{ set { _stateId = value; changed("stateId");} get { return _stateId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 归档文件借阅查看登记表
				/// </summary>
				[DataEntityAttribute("reFileBorrow")]
				public class reFileBorrow : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _fileid = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "fileid", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String fileid{ set { _fileid = value; changed("fileid");} get { return _fileid; } }

				
					private System.DateTime? _startTime = null;
					/// <summary>
					/// 借阅开始时间
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "startTime", FieldType = "datetime", FieldRemark = "借阅开始时间", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? startTime{ set { _startTime = value; changed("startTime");} get { return _startTime; } }

				
					private System.DateTime? _endTime = null;
					/// <summary>
					/// 借阅结束时间
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "endTime", FieldType = "datetime", FieldRemark = "借阅结束时间", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? endTime{ set { _endTime = value; changed("endTime");} get { return _endTime; } }

				
					private System.String _opinion = "";
					/// <summary>
					/// 申请借阅/查看的说明
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "opinion", FieldType = "varchar", FieldRemark = "申请借阅/查看的说明", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String opinion{ set { _opinion = value; changed("opinion");} get { return _opinion; } }

				
					private System.String _checkUser = "";
					/// <summary>
					/// 审核人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "checkUser", FieldType = "char", FieldRemark = "审核人", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String checkUser{ set { _checkUser = value; changed("checkUser");} get { return _checkUser; } }

				
					private System.String _checkOpinion = "";
					/// <summary>
					/// 审核意见
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "checkOpinion", FieldType = "varchar", FieldRemark = "审核意见", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String checkOpinion{ set { _checkOpinion = value; changed("checkOpinion");} get { return _checkOpinion; } }

				
					private System.String _backuser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "backuser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String backuser{ set { _backuser = value; changed("backuser");} get { return _backuser; } }

				
					private System.String _backopinion = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "backopinion", FieldType = "varchar", FieldRemark = "", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String backopinion{ set { _backopinion = value; changed("backopinion");} get { return _backopinion; } }

				
					private System.String _urgeOpinion = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "urgeOpinion", FieldType = "varchar", FieldRemark = "", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String urgeOpinion{ set { _urgeOpinion = value; changed("urgeOpinion");} get { return _urgeOpinion; } }

				
					private System.Boolean _isCheck = true;
					/// <summary>
					/// 审核是否通过
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "isCheck", FieldType = "bit", FieldRemark = "审核是否通过", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean isCheck{ set { _isCheck = value; changed("isCheck");} get { return _isCheck; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 借阅归还后标记为1
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "借阅归还后标记为1", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _fatherstate = "";
					/// <summary>
					/// 父状态
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "fatherstate", FieldType = "char", FieldRemark = "父状态", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String fatherstate{ set { _fatherstate = value; changed("fatherstate");} get { return _fatherstate; } }

				
					private System.String _state = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 申请人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "申请人", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifydate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifydate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifydate{ set { _modifydate = value; changed("modifydate");} get { return _modifydate; } }

				}


				
				/// <summary>
				/// 文件部门/人员关系表
				/// </summary>
				[DataEntityAttribute("reFileDepartment")]
				public class reFileDepartment : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _historyId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "historyId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String historyId{ set { _historyId = value; changed("historyId");} get { return _historyId; } }

				
					private System.String _departmentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "departmentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String departmentId{ set { _departmentId = value; changed("departmentId");} get { return _departmentId; } }

				
					private System.String _userId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "userId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String userId{ set { _userId = value; changed("userId");} get { return _userId; } }

				
					private System.String _disposwayId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "disposwayId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String disposwayId{ set { _disposwayId = value; changed("disposwayId");} get { return _disposwayId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 归档文件关系表
				/// </summary>
				[DataEntityAttribute("reFilingFile")]
				public class reFilingFile : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _fileId = "";
					/// <summary>
					/// 归档文件编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "fileId", FieldType = "char", FieldRemark = "归档文件编号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String fileId{ set { _fileId = value; changed("fileId");} get { return _fileId; } }

				
					private System.String _libraryId = "";
					/// <summary>
					/// 馆室ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "libraryId", FieldType = "char", FieldRemark = "馆室ID", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String libraryId{ set { _libraryId = value; changed("libraryId");} get { return _libraryId; } }

				
					private System.String _cabinetId = "";
					/// <summary>
					/// 大箱子编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "cabinetId", FieldType = "char", FieldRemark = "大箱子编号", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String cabinetId{ set { _cabinetId = value; changed("cabinetId");} get { return _cabinetId; } }

				
					private System.String _volumeId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volumeId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volumeId{ set { _volumeId = value; changed("volumeId");} get { return _volumeId; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 归档文件编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "归档文件编号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.Int32 _columns = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "columns", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Int32 columns{ set { _columns = value; changed("columns");} get { return _columns; } }

				
					private System.Int32 _lay = 0;
					/// <summary>
					/// 层编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "lay", FieldType = "int", FieldRemark = "层编号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Int32 lay{ set { _lay = value; changed("lay");} get { return _lay; } }

				
					private System.Int32 _caseCount = 0;
					/// <summary>
					/// 柜编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "caseCount", FieldType = "int", FieldRemark = "柜编号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Int32 caseCount{ set { _caseCount = value; changed("caseCount");} get { return _caseCount; } }

				
					private System.String _box = "";
					/// <summary>
					/// 盒编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "box", FieldType = "varchar", FieldRemark = "盒编号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String box{ set { _box = value; changed("box");} get { return _box; } }

				
					private System.String _approver = "";
					/// <summary>
					/// 批准人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "approver", FieldType = "char", FieldRemark = "批准人", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String approver{ set { _approver = value; changed("approver");} get { return _approver; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.DateTime? _createtime = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createtime", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createtime{ set { _createtime = value; changed("createtime");} get { return _createtime; } }

				
					private System.DateTime? _modifydate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifydate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifydate{ set { _modifydate = value; changed("modifydate");} get { return _modifydate; } }

				}


				
				/// <summary>
				/// 图片密级表
				/// </summary>
				[DataEntityAttribute("reImgSecurity")]
				public class reImgSecurity : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _PDFname = "";
					/// <summary>
					/// PDF名称
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "PDFname", FieldType = "varchar", FieldRemark = "PDF名称", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String PDFname{ set { _PDFname = value; changed("PDFname");} get { return _PDFname; } }

				
					private System.String _securityId = "";
					/// <summary>
					/// 图片密级
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityId", FieldType = "char", FieldRemark = "图片密级", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityId{ set { _securityId = value; changed("securityId");} get { return _securityId; } }

				
					private System.Int32 _pageCount = 0;
					/// <summary>
					/// 页码
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "pageCount", FieldType = "int", FieldRemark = "页码", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 pageCount{ set { _pageCount = value; changed("pageCount");} get { return _pageCount; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 文件处理结果与流程关系表
				/// </summary>
				[DataEntityAttribute("reOpintionFlie")]
				public class reOpintionFlie : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _typeId = "";
					/// <summary>
					/// 处理类型
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "typeId", FieldType = "char", FieldRemark = "处理类型", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String typeId{ set { _typeId = value; changed("typeId");} get { return _typeId; } }

				
					private System.String _flowId = "";
					/// <summary>
					/// 流程ID(收发文流程中关联流程id，档案扫描关联案卷id，档案管理关联归档文件id)
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "flowId", FieldType = "char", FieldRemark = "流程ID(收发文流程中关联流程id，档案扫描关联案卷id，档案管理关联归档文件id)", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String flowId{ set { _flowId = value; changed("flowId");} get { return _flowId; } }

				
					private System.String _stateId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "stateId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String stateId{ set { _stateId = value; changed("stateId");} get { return _stateId; } }

				
					private System.String _fatherstateId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "fatherstateId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String fatherstateId{ set { _fatherstateId = value; changed("fatherstateId");} get { return _fatherstateId; } }

				
					private System.String _optinion = "";
					/// <summary>
					/// 意见
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "optinion", FieldType = "varchar", FieldRemark = "意见", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String optinion{ set { _optinion = value; changed("optinion");} get { return _optinion; } }

				
					private System.DateTime? _limiteDate = null;
					/// <summary>
					/// 限办时间
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "limiteDate", FieldType = "datetime", FieldRemark = "限办时间", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? limiteDate{ set { _limiteDate = value; changed("limiteDate");} get { return _limiteDate; } }

				
					private System.String _createUserId = "";
					/// <summary>
					/// 责任者或创建人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createUserId", FieldType = "char", FieldRemark = "责任者或创建人", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String createUserId{ set { _createUserId = value; changed("createUserId");} get { return _createUserId; } }

				
					private System.String _receiveUserId = "";
					/// <summary>
					/// 接收人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "receiveUserId", FieldType = "char", FieldRemark = "接收人", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String receiveUserId{ set { _receiveUserId = value; changed("receiveUserId");} get { return _receiveUserId; } }

				
					private System.Int32 _parts = 0;
					/// <summary>
					/// 份数
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parts", FieldType = "int", FieldRemark = "份数", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Int32 parts{ set { _parts = value; changed("parts");} get { return _parts; } }

				
					private System.String _remark = "";
					/// <summary>
					/// 备注
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "remark", FieldType = "varchar", FieldRemark = "备注", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String remark{ set { _remark = value; changed("remark");} get { return _remark; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 拟办意见关系表
				/// </summary>
				[DataEntityAttribute("reProposeOpintion")]
				public class reProposeOpintion : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _userId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "userId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String userId{ set { _userId = value; changed("userId");} get { return _userId; } }

				
					private System.String _flowId = "";
					/// <summary>
					/// 文件ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "flowId", FieldType = "char", FieldRemark = "文件ID", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String flowId{ set { _flowId = value; changed("flowId");} get { return _flowId; } }

				
					private System.String _optinion = "";
					/// <summary>
					/// 意见
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "optinion", FieldType = "varchar", FieldRemark = "意见", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String optinion{ set { _optinion = value; changed("optinion");} get { return _optinion; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 清退单
				/// </summary>
				[DataEntityAttribute("reReturnFile")]
				public class reReturnFile : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _flowId = "";
					/// <summary>
					/// 文件ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "flowId", FieldType = "char", FieldRemark = "文件ID", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String flowId{ set { _flowId = value; changed("flowId");} get { return _flowId; } }

				
					private System.String _discription = "";
					/// <summary>
					/// 清退意见
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "discription", FieldType = "varchar", FieldRemark = "清退意见", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String discription{ set { _discription = value; changed("discription");} get { return _discription; } }

				
					private System.DateTime? _partsCount = null;
					/// <summary>
					/// 退份
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "partsCount", FieldType = "date", FieldRemark = "退份", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? partsCount{ set { _partsCount = value; changed("partsCount");} get { return _partsCount; } }

				
					private System.String _transferId = "";
					/// <summary>
					/// 移交人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "transferId", FieldType = "char", FieldRemark = "移交人", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String transferId{ set { _transferId = value; changed("transferId");} get { return _transferId; } }

				
					private System.String _recipient = "";
					/// <summary>
					/// 接收人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "recipient", FieldType = "char", FieldRemark = "接收人", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String recipient{ set { _recipient = value; changed("recipient");} get { return _recipient; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 督办文件关系表
				/// </summary>
				[DataEntityAttribute("reSuperviseFile")]
				public class reSuperviseFile : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _flowId = "";
					/// <summary>
					/// 文件流程ID
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "flowId", FieldType = "char", FieldRemark = "文件流程ID", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String flowId{ set { _flowId = value; changed("flowId");} get { return _flowId; } }

				
					private System.String _handleOpinion = "";
					/// <summary>
					/// 督办意见
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "handleOpinion", FieldType = "varchar", FieldRemark = "督办意见", Length = 500, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String handleOpinion{ set { _handleOpinion = value; changed("handleOpinion");} get { return _handleOpinion; } }

				
					private System.DateTime? _handleDate = null;
					/// <summary>
					/// 督办日期
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "handleDate", FieldType = "date", FieldRemark = "督办日期", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? handleDate{ set { _handleDate = value; changed("handleDate");} get { return _handleDate; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("RoleActionView")]
				public class RoleActionView : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _roleId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "roleId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String roleId{ set { _roleId = value; changed("roleId");} get { return _roleId; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.String _delId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "delId", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String delId{ set { _delId = value; changed("delId");} get { return _delId; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("tablename")]
				public class tablename : Entity
				{
					
			
					private System.Int32 _id = 0;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "int", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = true, AllowNull = false)]
					public System.Int32 id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "nchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _parentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String parentId{ set { _parentId = value; changed("parentId");} get { return _parentId; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("userDepart")]
				public class userDepart : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "nchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _departmentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "departmentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String departmentId{ set { _departmentId = value; changed("departmentId");} get { return _departmentId; } }

				
					private System.String _roleId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "roleId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String roleId{ set { _roleId = value; changed("roleId");} get { return _roleId; } }

				
					private System.String _securityId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityId{ set { _securityId = value; changed("securityId");} get { return _securityId; } }

				
					private System.String _loginName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "loginName", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String loginName{ set { _loginName = value; changed("loginName");} get { return _loginName; } }

				
					private System.String _password = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "password", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String password{ set { _password = value; changed("password");} get { return _password; } }

				
					private System.String _identityCardNum = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "identityCardNum", FieldType = "varchar", FieldRemark = "", Length = 18, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String identityCardNum{ set { _identityCardNum = value; changed("identityCardNum");} get { return _identityCardNum; } }

				
					private System.String _address = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "address", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String address{ set { _address = value; changed("address");} get { return _address; } }

				
					private System.String _phone = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "phone", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String phone{ set { _phone = value; changed("phone");} get { return _phone; } }

				
					private System.String _image = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "image", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String image{ set { _image = value; changed("image");} get { return _image; } }

				
					private System.String _deviceId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "deviceId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String deviceId{ set { _deviceId = value; changed("deviceId");} get { return _deviceId; } }

				
					private System.DateTime? _lastLoginDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "lastLoginDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? lastLoginDate{ set { _lastLoginDate = value; changed("lastLoginDate");} get { return _lastLoginDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.String _coucher = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "coucher", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String coucher{ set { _coucher = value; changed("coucher");} get { return _coucher; } }

				
					private System.String _certificateid = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "certificateid", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String certificateid{ set { _certificateid = value; changed("certificateid");} get { return _certificateid; } }

				
					private System.String _mail = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "mail", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String mail{ set { _mail = value; changed("mail");} get { return _mail; } }

				
					private System.String _postalcode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "postalcode", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String postalcode{ set { _postalcode = value; changed("postalcode");} get { return _postalcode; } }

				
					private System.String _unitname = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "unitname", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String unitname{ set { _unitname = value; changed("unitname");} get { return _unitname; } }

				
					private System.String _departname = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "departname", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String departname{ set { _departname = value; changed("departname");} get { return _departname; } }

				
					private System.String _rolesname = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "rolesname", FieldType = "varchar", FieldRemark = "", Length = 20, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String rolesname{ set { _rolesname = value; changed("rolesname");} get { return _rolesname; } }

				
					private System.String _securityname = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityname", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityname{ set { _securityname = value; changed("securityname");} get { return _securityname; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("userDepartView")]
				public class userDepartView : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _userid = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "userid", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String userid{ set { _userid = value; changed("userid");} get { return _userid; } }

				
					private System.String _username = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "username", FieldType = "nchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String username{ set { _username = value; changed("username");} get { return _username; } }

				
					private System.String _departmentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "departmentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String departmentId{ set { _departmentId = value; changed("departmentId");} get { return _departmentId; } }

				
					private System.String _parentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String parentId{ set { _parentId = value; changed("parentId");} get { return _parentId; } }

				
					private System.String _parentname = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "parentname", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String parentname{ set { _parentname = value; changed("parentname");} get { return _parentname; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("usermac")]
				public class usermac : Entity
				{
					
			
					private System.String _macAddress = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "macAddress", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String macAddress{ set { _macAddress = value; changed("macAddress");} get { return _macAddress; } }

				
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _name = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "name", FieldType = "nchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String name{ set { _name = value; changed("name");} get { return _name; } }

				
					private System.String _departmentId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "departmentId", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String departmentId{ set { _departmentId = value; changed("departmentId");} get { return _departmentId; } }

				
					private System.String _roleId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "roleId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String roleId{ set { _roleId = value; changed("roleId");} get { return _roleId; } }

				
					private System.String _securityId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityId{ set { _securityId = value; changed("securityId");} get { return _securityId; } }

				
					private System.String _loginName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "loginName", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String loginName{ set { _loginName = value; changed("loginName");} get { return _loginName; } }

				
					private System.String _password = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "password", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String password{ set { _password = value; changed("password");} get { return _password; } }

				
					private System.String _identityCardNum = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "identityCardNum", FieldType = "varchar", FieldRemark = "", Length = 18, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String identityCardNum{ set { _identityCardNum = value; changed("identityCardNum");} get { return _identityCardNum; } }

				
					private System.String _address = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "address", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String address{ set { _address = value; changed("address");} get { return _address; } }

				
					private System.String _phone = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "phone", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String phone{ set { _phone = value; changed("phone");} get { return _phone; } }

				
					private System.String _image = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "image", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String image{ set { _image = value; changed("image");} get { return _image; } }

				
					private System.String _deviceId = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "deviceId", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String deviceId{ set { _deviceId = value; changed("deviceId");} get { return _deviceId; } }

				
					private System.DateTime? _lastLoginDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "lastLoginDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? lastLoginDate{ set { _lastLoginDate = value; changed("lastLoginDate");} get { return _lastLoginDate; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.String _coucher = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "coucher", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String coucher{ set { _coucher = value; changed("coucher");} get { return _coucher; } }

				
					private System.String _certificateid = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "certificateid", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String certificateid{ set { _certificateid = value; changed("certificateid");} get { return _certificateid; } }

				
					private System.String _mail = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "mail", FieldType = "varchar", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String mail{ set { _mail = value; changed("mail");} get { return _mail; } }

				
					private System.String _postalcode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "postalcode", FieldType = "varbinary", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String postalcode{ set { _postalcode = value; changed("postalcode");} get { return _postalcode; } }

				
					private System.String _unitname = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "unitname", FieldType = "varbinary", FieldRemark = "", Length = 50, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String unitname{ set { _unitname = value; changed("unitname");} get { return _unitname; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("VirtualArchivesView")]
				public class VirtualArchivesView : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _subjects = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjects", FieldType = "varchar", FieldRemark = "", Length = 100, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjects{ set { _subjects = value; changed("subjects");} get { return _subjects; } }

				
					private System.String _year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.String _organization = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organization", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organization{ set { _organization = value; changed("organization");} get { return _organization; } }

				
					private System.String _storetime = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "storetime", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String storetime{ set { _storetime = value; changed("storetime");} get { return _storetime; } }

				
					private System.String _libraryname = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "libraryname", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String libraryname{ set { _libraryname = value; changed("libraryname");} get { return _libraryname; } }

				
					private System.String _Expr1 = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "Expr1", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String Expr1{ set { _Expr1 = value; changed("Expr1");} get { return _Expr1; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("virtualLibrary")]
				public class virtualLibrary : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = true, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _fileId = "";
					/// <summary>
					/// 文件编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "fileId", FieldType = "char", FieldRemark = "文件编号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String fileId{ set { _fileId = value; changed("fileId");} get { return _fileId; } }

				
					private System.String _libraryId = "";
					/// <summary>
					/// 馆室编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "libraryId", FieldType = "char", FieldRemark = "馆室编号", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String libraryId{ set { _libraryId = value; changed("libraryId");} get { return _libraryId; } }

				
					private System.String _cabinetId = "";
					/// <summary>
					/// 排编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "cabinetId", FieldType = "char", FieldRemark = "排编号", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String cabinetId{ set { _cabinetId = value; changed("cabinetId");} get { return _cabinetId; } }

				
					private System.String _volumeId = "";
					/// <summary>
					/// 案卷
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "volumeId", FieldType = "char", FieldRemark = "案卷", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String volumeId{ set { _volumeId = value; changed("volumeId");} get { return _volumeId; } }

				
					private System.String _filecode = "";
					/// <summary>
					/// 归档文件编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "filecode", FieldType = "char", FieldRemark = "归档文件编号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String filecode{ set { _filecode = value; changed("filecode");} get { return _filecode; } }

				
					private System.Int32 _columns = 0;
					/// <summary>
					/// 列编号
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "columns", FieldType = "int", FieldRemark = "列编号", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Int32 columns{ set { _columns = value; changed("columns");} get { return _columns; } }

				
					private System.Int32 _lay = 0;
					/// <summary>
					/// 层
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "lay", FieldType = "int", FieldRemark = "层", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Int32 lay{ set { _lay = value; changed("lay");} get { return _lay; } }

				
					private System.Int32 _caseCount = 0;
					/// <summary>
					/// 箱子
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "caseCount", FieldType = "int", FieldRemark = "箱子", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.Int32 caseCount{ set { _caseCount = value; changed("caseCount");} get { return _caseCount; } }

				
					private System.String _box = "";
					/// <summary>
					/// 文件盒
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "box", FieldType = "varchar", FieldRemark = "文件盒", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String box{ set { _box = value; changed("box");} get { return _box; } }

				
					private System.String _approver = "";
					/// <summary>
					/// 负责人
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "approver", FieldType = "char", FieldRemark = "负责人", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String approver{ set { _approver = value; changed("approver");} get { return _approver; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.DateTime? _createtime = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createtime", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createtime{ set { _createtime = value; changed("createtime");} get { return _createtime; } }

				
					private System.DateTime? _modifydate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifydate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifydate{ set { _modifydate = value; changed("modifydate");} get { return _modifydate; } }

				}


				
				/// <summary>
				/// 
				/// </summary>
				[DataEntityAttribute("VolumeView")]
				public class VolumeView : Entity
				{
					
			
					private System.String _id = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "id", FieldType = "char", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = false)]
					public System.String id{ set { _id = value; changed("id");} get { return _id; } }

				
					private System.String _contectCode = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "contectCode", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String contectCode{ set { _contectCode = value; changed("contectCode");} get { return _contectCode; } }

				
					private System.String _year = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "year", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String year{ set { _year = value; changed("year");} get { return _year; } }

				
					private System.String _VolumeName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "VolumeName", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String VolumeName{ set { _VolumeName = value; changed("VolumeName");} get { return _VolumeName; } }

				
					private System.String _discription = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "discription", FieldType = "varchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String discription{ set { _discription = value; changed("discription");} get { return _discription; } }

				
					private System.DateTime? _createDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "createDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? createDate{ set { _createDate = value; changed("createDate");} get { return _createDate; } }

				
					private System.DateTime? _modifyDate = null;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "modifyDate", FieldType = "datetime", FieldRemark = "", Length = 23, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.DateTime? modifyDate{ set { _modifyDate = value; changed("modifyDate");} get { return _modifyDate; } }

				
					private System.String _state = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "state", FieldType = "char", FieldRemark = "", Length = 2, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String state{ set { _state = value; changed("state");} get { return _state; } }

				
					private System.Boolean _IsDelete = true;
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "IsDelete", FieldType = "bit", FieldRemark = "", Length = 1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.Boolean IsDelete{ set { _IsDelete = value; changed("IsDelete");} get { return _IsDelete; } }

				
					private System.String _foundsName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "foundsName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String foundsName{ set { _foundsName = value; changed("foundsName");} get { return _foundsName; } }

				
					private System.String _storeName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "storeName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String storeName{ set { _storeName = value; changed("storeName");} get { return _storeName; } }

				
					private System.String _description = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "description", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String description{ set { _description = value; changed("description");} get { return _description; } }

				
					private System.String _CreateUser = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "CreateUser", FieldType = "nchar", FieldRemark = "", Length = 30, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String CreateUser{ set { _CreateUser = value; changed("CreateUser");} get { return _CreateUser; } }

				
					private System.String _organization = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organization", FieldType = "char", FieldRemark = "", Length = 4, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organization{ set { _organization = value; changed("organization");} get { return _organization; } }

				
					private System.String _subjectName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "subjectName", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String subjectName{ set { _subjectName = value; changed("subjectName");} get { return _subjectName; } }

				
					private System.String _organizName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "organizName", FieldType = "nvarchar", FieldRemark = "", Length = -1, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String organizName{ set { _organizName = value; changed("organizName");} get { return _organizName; } }

				
					private System.String _securityName = "";
					/// <summary>
					/// 
					/// </summary>
					[DataEntityFieldAttribute(FieldName = "securityName", FieldType = "varchar", FieldRemark = "", Length = 10, IsPrimaryKey = false, IsIdentity = false, AllowNull = true)]
					public System.String securityName{ set { _securityName = value; changed("securityName");} get { return _securityName; } }

				}


	
}