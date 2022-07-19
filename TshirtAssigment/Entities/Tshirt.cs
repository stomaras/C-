using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tshirt
    {
        [Key]
        public int Id { get; set; }

        //[Column("Mark")]
        //public string TypeMark
        //{ 
        //    get { return Mark.ToString(); }
        //    private set { Mark = value.ParseEnum<Mark>(); }
        //}

        //[NotMapped]
        public Mark Mark { get; set; }


        //[Column("Color")]
        //public string TypeColor
        //{
        //    get
        //    {
        //        return Color.ToString();
        //    }
        //    private set
        //    {
        //        Color = value.ParseEnum<Color>();
        //    }
        //}

        //[NotMapped]
        public Color Color { get; set; }


        //[Column("Size")]
        //public string TypeSize
        //{
        //    get
        //    {
        //        return Size.ToString();
        //    }
        //    private set
        //    {
        //        Size = value.ParseEnum<Size>();
        //    }
        //}

        //[NotMapped]
        public Size Size { get; set; }

        //[Column("Fabric")]
        //public string TypeFabric
        //{
        //    get
        //    {
        //        return Fabric.ToString();
        //    }
        //    private set
        //    {
        //        Fabric = value.ParseEnum<Fabric>();
        //    }
        //}


        //[NotMapped]
        public Fabric Fabric { get; set; }
        public int? Price { get; set; }

    }
}
