using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ModelLibrary.Models
{
    public class BattelField
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "XML"), Required]
        public string Field { get; set; }

        [NotMapped]
        public XmlDocument Schema
        {
            get
            {
                var doc = new XmlDocument();
                doc.LoadXml(Field);
                return doc;
            }
            set { Field = value.InnerXml; }
        }
    }
}
