﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 04.11.2020 10:49:01
namespace Laba4ASPModel
{
    
    /// <summary>
    /// There are no comments for Laba4ASPEntities1 in the schema.
    /// </summary>
    public partial class Laba4ASPEntities1 : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Laba4ASPEntities1 object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Laba4ASPEntities1(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for NOTEs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<NOTE> NOTEs
        {
            get
            {
                if ((this._NOTEs == null))
                {
                    this._NOTEs = base.CreateQuery<NOTE>("NOTEs");
                }
                return this._NOTEs;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<NOTE> _NOTEs;
        /// <summary>
        /// There are no comments for STUDENTs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<STUDENT> STUDENTs
        {
            get
            {
                if ((this._STUDENTs == null))
                {
                    this._STUDENTs = base.CreateQuery<STUDENT>("STUDENTs");
                }
                return this._STUDENTs;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<STUDENT> _STUDENTs;
        /// <summary>
        /// There are no comments for NOTEs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToNOTEs(NOTE nOTE)
        {
            base.AddObject("NOTEs", nOTE);
        }
        /// <summary>
        /// There are no comments for STUDENTs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToSTUDENTs(STUDENT sTUDENT)
        {
            base.AddObject("STUDENTs", sTUDENT);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = "<edmx:Edmx Version=\"1.0\" xmlns:edmx=\"http://schemas.microsoft.com/ado/2007/06/edm" +
                "x\"><edmx:DataServices m:DataServiceVersion=\"1.0\" m:MaxDataServiceVersion=\"3.0\" x" +
                "mlns:m=\"http://schemas.microsoft.com/ado/2007/08/dataservices/metadata\"><Schema " +
                "Namespace=\"Laba4ASPModel\" xmlns=\"http://schemas.microsoft.com/ado/2009/11/edm\"><" +
                "EntityType Name=\"NOTE\"><Key><PropertyRef Name=\"id\" /></Key><Property Name=\"id\" T" +
                "ype=\"Edm.Int32\" Nullable=\"false\" p6:StoreGeneratedPattern=\"Identity\" xmlns:p6=\"h" +
                "ttp://schemas.microsoft.com/ado/2009/02/edm/annotation\" /><Property Name=\"subjec" +
                "t\" Type=\"Edm.String\" MaxLength=\"255\" FixedLength=\"false\" Unicode=\"true\" /><Prope" +
                "rty Name=\"note1\" Type=\"Edm.Int32\" /><Property Name=\"student_id\" Type=\"Edm.Int32\"" +
                " /><NavigationProperty Name=\"STUDENT\" Relationship=\"Laba4ASPModel.FK__NOTE__stud" +
                "ent_id__267ABA7A\" ToRole=\"STUDENT\" FromRole=\"NOTE\" /></EntityType><EntityType Na" +
                "me=\"STUDENT\"><Key><PropertyRef Name=\"id\" /></Key><Property Name=\"id\" Type=\"Edm.I" +
                "nt32\" Nullable=\"false\" p6:StoreGeneratedPattern=\"Identity\" xmlns:p6=\"http://sche" +
                "mas.microsoft.com/ado/2009/02/edm/annotation\" /><Property Name=\"name\" Type=\"Edm." +
                "String\" MaxLength=\"255\" FixedLength=\"false\" Unicode=\"true\" /><NavigationProperty" +
                " Name=\"NOTEs\" Relationship=\"Laba4ASPModel.FK__NOTE__student_id__267ABA7A\" ToRole" +
                "=\"NOTE\" FromRole=\"STUDENT\" /></EntityType><Association Name=\"FK__NOTE__student_i" +
                "d__267ABA7A\"><End Type=\"Laba4ASPModel.STUDENT\" Role=\"STUDENT\" Multiplicity=\"0..1" +
                "\" /><End Type=\"Laba4ASPModel.NOTE\" Role=\"NOTE\" Multiplicity=\"*\" /><ReferentialCo" +
                "nstraint><Principal Role=\"STUDENT\"><PropertyRef Name=\"id\" /></Principal><Depende" +
                "nt Role=\"NOTE\"><PropertyRef Name=\"student_id\" /></Dependent></ReferentialConstra" +
                "int></Association></Schema><Schema Namespace=\"lab6\" xmlns=\"http://schemas.micros" +
                "oft.com/ado/2009/11/edm\"><EntityContainer Name=\"Laba4ASPEntities1\" m:IsDefaultEn" +
                "tityContainer=\"true\"><EntitySet Name=\"NOTEs\" EntityType=\"Laba4ASPModel.NOTE\" /><" +
                "EntitySet Name=\"STUDENTs\" EntityType=\"Laba4ASPModel.STUDENT\" /><AssociationSet N" +
                "ame=\"FK__NOTE__student_id__267ABA7A\" Association=\"Laba4ASPModel.FK__NOTE__studen" +
                "t_id__267ABA7A\"><End Role=\"NOTE\" EntitySet=\"NOTEs\" /><End Role=\"STUDENT\" EntityS" +
                "et=\"STUDENTs\" /></AssociationSet></EntityContainer></Schema></edmx:DataServices>" +
                "</edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for Laba4ASPModel.NOTE in the schema.
    /// </summary>
    /// <KeyProperties>
    /// id
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("id")]
    public partial class NOTE
    {
        /// <summary>
        /// Create a new NOTE object.
        /// </summary>
        /// <param name="ID">Initial value of id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static NOTE CreateNOTE(int ID)
        {
            NOTE nOTE = new NOTE();
            nOTE.id = ID;
            return nOTE;
        }
        /// <summary>
        /// There are no comments for Property id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                this.OnidChanging(value);
                this._id = value;
                this.OnidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _id;
        partial void OnidChanging(int value);
        partial void OnidChanged();
        /// <summary>
        /// There are no comments for Property subject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string subject
        {
            get
            {
                return this._subject;
            }
            set
            {
                this.OnsubjectChanging(value);
                this._subject = value;
                this.OnsubjectChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _subject;
        partial void OnsubjectChanging(string value);
        partial void OnsubjectChanged();
        /// <summary>
        /// There are no comments for Property note1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> note1
        {
            get
            {
                return this._note1;
            }
            set
            {
                this.Onnote1Changing(value);
                this._note1 = value;
                this.Onnote1Changed();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _note1;
        partial void Onnote1Changing(global::System.Nullable<int> value);
        partial void Onnote1Changed();
        /// <summary>
        /// There are no comments for Property student_id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> student_id
        {
            get
            {
                return this._student_id;
            }
            set
            {
                this.Onstudent_idChanging(value);
                this._student_id = value;
                this.Onstudent_idChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _student_id;
        partial void Onstudent_idChanging(global::System.Nullable<int> value);
        partial void Onstudent_idChanged();
        /// <summary>
        /// There are no comments for STUDENT in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public STUDENT STUDENT
        {
            get
            {
                return this._STUDENT;
            }
            set
            {
                this._STUDENT = value;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private STUDENT _STUDENT;
    }
    /// <summary>
    /// There are no comments for Laba4ASPModel.STUDENT in the schema.
    /// </summary>
    /// <KeyProperties>
    /// id
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("id")]
    public partial class STUDENT
    {
        /// <summary>
        /// Create a new STUDENT object.
        /// </summary>
        /// <param name="ID">Initial value of id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static STUDENT CreateSTUDENT(int ID)
        {
            STUDENT sTUDENT = new STUDENT();
            sTUDENT.id = ID;
            return sTUDENT;
        }
        /// <summary>
        /// There are no comments for Property id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                this.OnidChanging(value);
                this._id = value;
                this.OnidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _id;
        partial void OnidChanging(int value);
        partial void OnidChanged();
        /// <summary>
        /// There are no comments for Property name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this.OnnameChanging(value);
                this._name = value;
                this.OnnameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _name;
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        /// <summary>
        /// There are no comments for NOTEs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Collections.ObjectModel.Collection<NOTE> NOTEs
        {
            get
            {
                return this._NOTEs;
            }
            set
            {
                if ((value != null))
                {
                    this._NOTEs = value;
                }
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Collections.ObjectModel.Collection<NOTE> _NOTEs = new global::System.Collections.ObjectModel.Collection<NOTE>();
    }
}