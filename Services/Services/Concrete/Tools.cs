using ApiIosep.Services.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace ApiIosep.Services
{
    public class Tools : ITools
    {

        public string RandomString(int length, bool onlyNumber = false, bool onlyMayus = true)
        {
            string valid = onlyNumber ? "1234567890" :
                onlyMayus ? "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890" :
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }

        public string CodigoBarra(string comprobante, decimal importe, DateTime vence, DateTime segVence)
        {
            string cpBanco = "70";
            cpBanco += comprobante.Substring(4, 2) + comprobante.Substring(comprobante.Length - 8, 8);
            DateTime fechaDif = new DateTime(vence.Year, 1, 1);
            TimeSpan diferenciaDias = vence - fechaDif;
            cpBanco += (diferenciaDias.Days + 1).ToString().PadLeft(3, '0');
            cpBanco += vence.ToString("yy");
            string monto = "";
            if (importe > 99999)
                monto = importe.ToString("0.00").Replace(",", "").PadLeft(8, '0');
            else
                monto = importe.ToString("0.00").Replace(",", "").PadLeft(7, '0');
            cpBanco += monto;

            diferenciaDias = segVence - fechaDif;
            cpBanco += (diferenciaDias.Days + 1).ToString().PadLeft(3, '0');
            cpBanco += segVence.ToString("yy");
            cpBanco += monto;

            //genero
            int largo = cpBanco.Trim().Length;
            int suma = int.Parse(cpBanco[..1]), j = 1;
            suma += int.Parse(cpBanco.Substring(1, 1)) * 3;
            suma += int.Parse(cpBanco.Substring(2, 1)) * 5;
            for (int i = 3; i < largo; i++)
            {
                int valorMultiplica = 1;
                switch (j)
                {
                    case 1:
                        valorMultiplica = 7;
                        j++;
                        break;
                    case 2:
                        valorMultiplica = 9;
                        j++;
                        break;
                    case 3:
                        valorMultiplica = 3;
                        j++;
                        break;
                    case 4:
                        valorMultiplica = 5;
                        j = 1;
                        break;
                }
                suma += int.Parse(cpBanco.Substring(i, 1)) * valorMultiplica;
            }
            string resultado = ((suma / 2) - ((suma % 2) / 2)).ToString();
            int resul = int.Parse(resultado.Substring(resultado.Length - 1, 1));
            cpBanco = "003" + cpBanco + resul.ToString().Substring(0, 1);
            return cpBanco;
        }
    }
}
