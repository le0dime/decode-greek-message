using System;

namespace Decode
{
    class Program
    {
        static string code = "ΨφΔξβΨμλΓΛ ΡΘξΡΛξΠμφ λΨξΘΓΠμΓΔ ΨξΛφζΡμλΓ ΔξΛφζΡμλΓ ΔξΛφζΡμλΓ ΔξΨφΔξΡΛξ μηφΔΨξΔΡξ μΨλΓΘξαΓΔ ΡΩΓΘξΣΡΔξ ΡΩξλμΨΩΨξ ΓξΛΓξΩΨζΛ ΡξφΠηΓΛΔΓ ΔξΦΓξΘηξλ μΨΩΨξΔφΠΩ φΘφβΨξΓζμ φΡμΨΩξΛΓΘ ξΞμΨΣφΩαφ ΓΘξηΩφΔΓΘ ξΔΡΛξΘηΔξ ΦξΛΨΘξΛφζ μΡΘξΔΡΛξβ ηΩΔΨξμΡΘΞ ΨΩΔΡΩξΓΛξ ΠμΓΩξΞηΡζ ΛΨξΓμΠΡΩλ φΩΨξΘΓΛηΔ ξΓΛξΠμΓΩξ ΞηΡζΛΨξΓμ ΠΡΩλφΩΨξΘ ΓΛηΔξΦξΛΨ ΘξΛφζμΡΘξ ΔΡΛξβηΩΔΨ ξμΡΘΞΨΩΔΡ ΩξΓΛξΠμΓΩ ξΞηΡζΛΨξΓ μΠΡΩλφΩΨξ ΘΓΛηΔξΦξΛ ΨΘξΛφζμΡΘ ξΔΡΛξβηΩΔ ΨξμΡΘΞΨΩΔ ΡΩξΓΛξΠμΓ ΩξΞηΡζΛΨξ ΓμΠΡΩλφΩΨ ξΘΓΛηΔξαΨ μΨξΘΡΓΩξΡ λΡμΩΨΘξΛΨ ΘξΛΓημΡΛΡ ΘξϑηΡξΘηΞ φβΨΘξαΨΩΘ ΡΠηφμξϑηΡ ξΘηΞφβΨΘξ αΨΩΘΡΠηφμ ξαΨμΨΩΓΔΨ ΘξΔΡξΠΛΨμ φΓξΣφΣΓβΨ ΘξΨξεημΡβ ΨΘξαΨΩξΠΛ ΨμφΓξβΨμφ μξΨξεημΡβ ΨΘξαΨΩξΠΛ ΨμφΓξβΨμφ μξΨξεημΡβ ΨΘξαΨΩξΠΛ ΨμφΓξβΨμφ μ";
        static void Main(string[] args)
        {
            //Pasamos el string a un array de caracteres
            var chars = code.ToCharArray();
            //String final
            string message = string.Empty;

            //Loop del array
            foreach(var character in chars)
            {
                //Si el char es un espacio en blanco, lo agregamos directamente al string
                if (!char.IsWhiteSpace(character))
                {
                    //Obtenemos el codigo UNICODE
                    int num = character;
                    //UNICODE - 848 = UNICODE equivalente en nuestro alfabeto
                    num = num - 848;
                    //Agregamos el caracter obtenido
                    message += (char)num;
                }
                else
                {
                    message += " ";
                }
            }

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
