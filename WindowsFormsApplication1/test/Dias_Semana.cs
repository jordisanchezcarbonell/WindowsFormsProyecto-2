//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COMPLETE_FLAT_UI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dias_Semana
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dias_Semana()
        {
            this.Horario_Act_Con = new HashSet<Horario_Act_Con>();
            this.Horario_Act_Dem = new HashSet<Horario_Act_Dem>();
            this.Instalacion_Horario = new HashSet<Instalacion_Horario>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horario_Act_Con> Horario_Act_Con { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horario_Act_Dem> Horario_Act_Dem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instalacion_Horario> Instalacion_Horario { get; set; }
    }
}
