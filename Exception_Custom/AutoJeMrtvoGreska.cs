using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Exception_Proces_Multiple
{
    /// <summary>
    /// KLASA KOJA NALJEĐUJE OD "ApplicationException" I ZAPRAVO JE NAŠ CUSTOM ERROR. 
    /// SA CUSTOM PORUKOM, IZVOROM I VREMENOM GREŠKE. 
    /// </summary>
    [Serializable]
    class AutoJeMrtvoGreska : ApplicationException
    {

        // Polja i Osobine.
        private string detaljiPoruke = String.Empty;
        public DateTime VrijemNaljepGreske { get; set; }
        public string IzvorGreske { get; set; }

        // Konstruktori.
        public AutoJeMrtvoGreska() { }

        public AutoJeMrtvoGreska(string poruka, string izvor, DateTime vrijeme)
        {
            detaljiPoruke = poruka;
            IzvorGreske = izvor;
            VrijemNaljepGreske = vrijeme;
        }

        #region OVE KONSTRUKTORE SUGERIRAO JE CODERUSH. PA SAM IH UVRSTIO U KLASU.

        public AutoJeMrtvoGreska(string message)
            : base(message)
        {

        }
        public AutoJeMrtvoGreska(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }
        protected AutoJeMrtvoGreska(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            
        }

        #endregion

        // Override Exception.Message osobine
        public override string Message
        {
            get
            {
                return string.Format("Auto Greška poruka: {0}.", detaljiPoruke);
            }
        } 

    }
}
