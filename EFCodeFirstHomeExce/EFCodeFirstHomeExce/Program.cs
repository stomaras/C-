using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodeFirstHomeExce.Database;
using EFCodeFirstHomeExce.Entities;
namespace EFCodeFirstHomeExce
{
    internal class Program
    {
        /*
         * Let's assume that we want to create a simple application for XYZ School. Users of this school application
         * should be able to add and update students,grades,teachers, and courses information.
         * Instead of designing database tables first, let's start creating classes for our school domain, as and 
         * when needed. First, create the Student and Grade classes where every Student is associated with one Grade. This called
         * a one-to-many relationship.
         * 
         * The Code-First Approach also requires a context class which should be derived from DbContext class
         * Schema -> By default, EF creates all the DB objects into the dbo schema
         * Table Name -> <Entity Class Name> + 's'... For Example Student domain class(entity) would map to the Students table.
         * Primary Key Name -> 1) Id,
         *                     2) <Entity Class Name> + "Id"(case insensitive)
         *                     EF will create a primary key column for the property named Id or <Entity Class Name> + "Id"(case insensitive)
         * Foreign key property
         * Name                 : By Default EF will look for the foreign key property with the same name as the principal entity 
         *                        primary key name. If the foreign key property does not eixst, the EF will create an FK column
         *                        in the Db table with <Dependent Navigation Property Name> + "_" + <Principal Entity Primary Key Property Name>
         *                        e.g EF will create Grade_GradeId foreign key column in the Students table if th Student entity does not 
         *                        contain forign key property for Grade.
         * Null Column : EF creates a null column for all reference type properties and nullable primitive properties e.g string, Nullable<int>
         * Student, Grade (all class type properties)
         * 
         * Not Null Column : EF Creates NotNull Columns for PK properties and non-nullable value type properties e.g int,float,decimal,datetime e.t.c
         * DB Columns order : EF will create DB columns in the saame order like the properties in an entity class. However, PK Columns would be
         *                     moved first.
         * Properties Mapping to DB : By default, all properties will map to the database. Use the [NotMapped] attribute to exclude property or class
         *                            from DB mapping
         * Cascade Delete : Enabled by default for all types of relationships
         * 
         * The following table list C# data type mapped with SQL Server data type.
         *  c# Data Type        Mapping to SQL Server Data Type
         *  
         *  int                 int
         *  string              nvarchar(Max)
         *  decimal             decimal(18,2)
         *  float               real
         *  byte[]              varbinary(Max)
         *  datetime            datetime
         *  bool                bit
         *  byte                tinyint
         *  short               smallint
         *  long                bigint
         *  double              float
         *  char                No mapping
         *  sbyte               No mapping
         *  object              No mapping
         *
         *
         */
        static void Main(string[] args)
        {
            using(var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
