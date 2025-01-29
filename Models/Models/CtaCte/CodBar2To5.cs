namespace ApiIosep.Models.CtaCte
{
    public class CodBar2To5
    {
        private string cadena;
        public string codbar2to5(string cadena)
        {
            this.cadena = cadena.Trim();
            string cad = "", cut = "";
            for (int i = 0; i < this.cadena.Length; i += 2)
            {
                cut = this.cadena.Substring(i);
                int caracter = 0;
                try
                {
                    if (cut.Length > 1)
                        caracter = int.Parse(cut.Substring(0, 2));
                    else
                        caracter = int.Parse(this.cadena.Substring(i));
                }
                catch
                {
                    caracter = int.Parse(cut.Substring(0));
                }
                if (caracter < 50)
                    cad += (char)(caracter + 48);
                else
                    cad += (char)(caracter + 142);
            }
            return ((char)40) + cad + ((char)41);
        }
    }
}
