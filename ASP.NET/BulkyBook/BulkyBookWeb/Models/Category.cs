using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        /*
         * Inside this Category class, we need to create the properties that we formed for our table.
         * We want to push this model in Database in order to create a table with these four columns.
         * We might want to set the ID as Primary Key and since it's an integer, we want to make that an identity column 
         * We could also add a validation that name is a required property and it should not be null.
         * So on the property when you want to configure some more special details, we have some special attributes that you can use.
         * We want the ID column to be an identity column and act as primary key on this table.
         * Note When you working with Entity Framework Core, there are two models. One is code first and one is database first.
         */
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
