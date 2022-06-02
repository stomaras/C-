# C-

# FLUENT API
  - can be applied when EF builds a model from your domain classes.
  - ou can inject the Fluent API configurations by overriding the OnModelCreating method of DbContext in Entity Framework 6.X
  - You can use modelBuilder, an object of DbModelBuilder class to configur domain classes. 
  - The DbModelBuilder is called Fluent API because you can call different methods in a chain. 

# Data Annotation Attributes
  - Data Annotationss attributes are .NET attributes which can be applied on an entity class or properties to override default conventions in EF6 and EF Core
  - Data annotation attributes are included in the System.ComponentModel.DataAnnotations and System.ComponentModel.DataAnnotations.Schema namespaces in EF6 as well as 
    in EF Core. These data annotations attributes work in the same ay in EF6 and EF Core and are valid in both.
  - NOTE !!! Data annotations only give you a subset of configuration options. Fluent API provides a full set of configuration options available in Code First
#Table 

  # System.ComponentModel.DataAnnotations Attributes

  Attribute        Description
  
  Key              Can be applied to a property to specify a key property in an entity and make the corresponding column a PK column in db
  Timestamp        Can be applied to a property to specify the data type of a corresponding column in the database as rowversion.
  ConcurrencyCheck Can be applied to property to specify that the corresponding column should be included in the optimistic concurrency check.
  Required         Can be applied to a property to specify that the corresponding column is a NotNull Column in the database
  MinLength        Can be applied to a property to specify that the minimum string length allowed in the corresponding column in the database
  MaxLength        Can be applied to a property to specify the maximum string length allowed in the corresponding column in the database
  StringLength     Can be applied to a property to specify the maximum string length allowed in the corresponding column in db
  
  # System.ComponentModel.DataAnnotations.Schema Attributes
  
  Attribute         Description
  Table             Can be applied to an entity class to configure the corresponding table name and schema in the database
  Column            Can be applied to a property to configure the correspondng column name, order and data type in the database
  Index             Can be applied to a property to configure that the corresponding column should have an Index in the database.
  ForeignKey        Can be applied to a property to mark it as foreign key property.
  NotMapped         Can be applied to a property or entity class which should be excluded from the model and should not generate a corresponding column or table in the                     database.
  
  DatabaseGenerated	Can be applied to a property to configure how the underlying database should generate the value for the corresponding column e.g. identity,                             computed or none.
  InverseProperty   Can be applied to a property to specify the inverse of a navigation property that represents the other end of the same relationship.
  
  # Note
  
  In EF6, the Key attribute along with the column attribute can be applied o multiple properties of an entity class which will create composite 
  Primary Key Columns in the Database
  
  EF Core does not support creating a composite key using the Key attribute. You have to use the Fluent API HasKey() Function in EF Core
  
