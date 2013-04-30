﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace MySql.Data.MySqlClient.Tests.Xunit
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class sakilaEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new sakilaEntities object using the connection string found in the 'sakilaEntities' section of the application configuration file.
        /// </summary>
        public sakilaEntities() : base("name=sakilaEntities", "sakilaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new sakilaEntities object.
        /// </summary>
        public sakilaEntities(string connectionString) : base(connectionString, "sakilaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new sakilaEntities object.
        /// </summary>
        public sakilaEntities(EntityConnection connection) : base(connection, "sakilaEntities")
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
        public ObjectSet<actor> actors
        {
            get
            {
                if ((_actors == null))
                {
                    _actors = base.CreateObjectSet<actor>("actors");
                }
                return _actors;
            }
        }
        private ObjectSet<actor> _actors;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the actors EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToactors(actor actor)
        {
            base.AddObject("actors", actor);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="sakilaModel", Name="actor")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class actor : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new actor object.
        /// </summary>
        /// <param name="first_name">Initial value of the first_name property.</param>
        /// <param name="last_name">Initial value of the last_name property.</param>
        /// <param name="last_update">Initial value of the last_update property.</param>
        /// <param name="actor_id">Initial value of the actor_id property.</param>
        public static actor Createactor(global::System.String first_name, global::System.String last_name, global::System.DateTime last_update, global::System.Int32 actor_id)
        {
            actor actor = new actor();
            actor.first_name = first_name;
            actor.last_name = last_name;
            actor.last_update = last_update;
            actor.actor_id = actor_id;
            return actor;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String first_name
        {
            get
            {
                return _first_name;
            }
            set
            {
                Onfirst_nameChanging(value);
                ReportPropertyChanging("first_name");
                _first_name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("first_name");
                Onfirst_nameChanged();
            }
        }
        private global::System.String _first_name;
        partial void Onfirst_nameChanging(global::System.String value);
        partial void Onfirst_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String last_name
        {
            get
            {
                return _last_name;
            }
            set
            {
                Onlast_nameChanging(value);
                ReportPropertyChanging("last_name");
                _last_name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("last_name");
                Onlast_nameChanged();
            }
        }
        private global::System.String _last_name;
        partial void Onlast_nameChanging(global::System.String value);
        partial void Onlast_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime last_update
        {
            get
            {
                return _last_update;
            }
            set
            {
                Onlast_updateChanging(value);
                ReportPropertyChanging("last_update");
                _last_update = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("last_update");
                Onlast_updateChanged();
            }
        }
        private global::System.DateTime _last_update;
        partial void Onlast_updateChanging(global::System.DateTime value);
        partial void Onlast_updateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 actor_id
        {
            get
            {
                return _actor_id;
            }
            set
            {
                if (_actor_id != value)
                {
                    Onactor_idChanging(value);
                    ReportPropertyChanging("actor_id");
                    _actor_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("actor_id");
                    Onactor_idChanged();
                }
            }
        }
        private global::System.Int32 _actor_id;
        partial void Onactor_idChanging(global::System.Int32 value);
        partial void Onactor_idChanged();

        #endregion

    
    }

    #endregion

    
}
