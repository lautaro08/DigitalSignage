using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework.Mappings
{
    /// <summary>
    /// Mapeo de la clase text source
    /// </summary>
    public class TextSourceMap : EntityTypeConfiguration<TextSource>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TextSourceMap()
        {
            // nombre de la tabla
            this.ToTable("TextSources");

            // columna 'text' obligatoria
            this.Property(pTextSource => pTextSource.Text)
                .IsRequired();

        }
    }
}
