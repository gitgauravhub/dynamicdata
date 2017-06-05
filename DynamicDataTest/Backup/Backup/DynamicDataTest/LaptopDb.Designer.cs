﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("testDbModel", "FK_Laptops_Manufacturers", "Manufacturers", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(DynamicDataTest.Manufacturer), "Laptops", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DynamicDataTest.Laptop), true)]

#endregion

namespace DynamicDataTest
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class testDbEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new testDbEntities object using the connection string found in the 'testDbEntities' section of the application configuration file.
        /// </summary>
        public testDbEntities() : base("name=testDbEntities", "testDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new testDbEntities object.
        /// </summary>
        public testDbEntities(string connectionString) : base(connectionString, "testDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new testDbEntities object.
        /// </summary>
        public testDbEntities(EntityConnection connection) : base(connection, "testDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Laptop> Laptops
        {
            get
            {
                if ((_Laptops == null))
                {
                    _Laptops = base.CreateObjectSet<Laptop>("Laptops");
                }
                return _Laptops;
            }
        }
        private ObjectSet<Laptop> _Laptops;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Manufacturer> Manufacturers
        {
            get
            {
                if ((_Manufacturers == null))
                {
                    _Manufacturers = base.CreateObjectSet<Manufacturer>("Manufacturers");
                }
                return _Manufacturers;
            }
        }
        private ObjectSet<Manufacturer> _Manufacturers;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Laptops EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLaptops(Laptop laptop)
        {
            base.AddObject("Laptops", laptop);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Manufacturers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToManufacturers(Manufacturer manufacturer)
        {
            base.AddObject("Manufacturers", manufacturer);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="testDbModel", Name="Laptop")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Laptop : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Laptop object.
        /// </summary>
        /// <param name="laptopId">Initial value of the laptopId property.</param>
        public static Laptop CreateLaptop(global::System.Int32 laptopId)
        {
            Laptop laptop = new Laptop();
            laptop.laptopId = laptopId;
            return laptop;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 laptopId
        {
            get
            {
                return _laptopId;
            }
            set
            {
                if (_laptopId != value)
                {
                    OnlaptopIdChanging(value);
                    ReportPropertyChanging("laptopId");
                    _laptopId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("laptopId");
                    OnlaptopIdChanged();
                }
            }
        }
        private global::System.Int32 _laptopId;
        partial void OnlaptopIdChanging(global::System.Int32 value);
        partial void OnlaptopIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LaptopName
        {
            get
            {
                return _LaptopName;
            }
            set
            {
                OnLaptopNameChanging(value);
                ReportPropertyChanging("LaptopName");
                _LaptopName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LaptopName");
                OnLaptopNameChanged();
            }
        }
        private global::System.String _LaptopName;
        partial void OnLaptopNameChanging(global::System.String value);
        partial void OnLaptopNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ManfId
        {
            get
            {
                return _ManfId;
            }
            set
            {
                OnManfIdChanging(value);
                ReportPropertyChanging("ManfId");
                _ManfId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ManfId");
                OnManfIdChanged();
            }
        }
        private Nullable<global::System.Int32> _ManfId;
        partial void OnManfIdChanging(Nullable<global::System.Int32> value);
        partial void OnManfIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ScreenSize
        {
            get
            {
                return _ScreenSize;
            }
            set
            {
                OnScreenSizeChanging(value);
                ReportPropertyChanging("ScreenSize");
                _ScreenSize = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ScreenSize");
                OnScreenSizeChanged();
            }
        }
        private global::System.String _ScreenSize;
        partial void OnScreenSizeChanging(global::System.String value);
        partial void OnScreenSizeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Processor
        {
            get
            {
                return _Processor;
            }
            set
            {
                OnProcessorChanging(value);
                ReportPropertyChanging("Processor");
                _Processor = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Processor");
                OnProcessorChanged();
            }
        }
        private global::System.String _Processor;
        partial void OnProcessorChanging(global::System.String value);
        partial void OnProcessorChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("testDbModel", "FK_Laptops_Manufacturers", "Manufacturers")]
        public Manufacturer Manufacturer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Manufacturer>("testDbModel.FK_Laptops_Manufacturers", "Manufacturers").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Manufacturer>("testDbModel.FK_Laptops_Manufacturers", "Manufacturers").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Manufacturer> ManufacturerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Manufacturer>("testDbModel.FK_Laptops_Manufacturers", "Manufacturers");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Manufacturer>("testDbModel.FK_Laptops_Manufacturers", "Manufacturers", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="testDbModel", Name="Manufacturer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Manufacturer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Manufacturer object.
        /// </summary>
        /// <param name="manfId">Initial value of the ManfId property.</param>
        public static Manufacturer CreateManufacturer(global::System.Int32 manfId)
        {
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.ManfId = manfId;
            return manufacturer;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ManfId
        {
            get
            {
                return _ManfId;
            }
            set
            {
                if (_ManfId != value)
                {
                    OnManfIdChanging(value);
                    ReportPropertyChanging("ManfId");
                    _ManfId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ManfId");
                    OnManfIdChanged();
                }
            }
        }
        private global::System.Int32 _ManfId;
        partial void OnManfIdChanging(global::System.Int32 value);
        partial void OnManfIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ManfName
        {
            get
            {
                return _ManfName;
            }
            set
            {
                OnManfNameChanging(value);
                ReportPropertyChanging("ManfName");
                _ManfName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ManfName");
                OnManfNameChanged();
            }
        }
        private global::System.String _ManfName;
        partial void OnManfNameChanging(global::System.String value);
        partial void OnManfNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("testDbModel", "FK_Laptops_Manufacturers", "Laptops")]
        public EntityCollection<Laptop> Laptops
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Laptop>("testDbModel.FK_Laptops_Manufacturers", "Laptops");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Laptop>("testDbModel.FK_Laptops_Manufacturers", "Laptops", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
