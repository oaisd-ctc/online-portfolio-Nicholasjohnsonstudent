namespace Func
{
    class func
    {
        public static double Multiply(double[] nums)
        {
            double total = 1.0;
            foreach (double number in nums)
            {
                total *= number;
            }
            return total;
        }
        public static double Divide(double[] nums)
        {
            double total = 0;
            total = nums[0];
            total /= nums[1];
            return total;
        }
        public static int Modulus(int[] nums)
        {
            int total = nums[0] % nums[1];
            return total;
        }
        public static double Add(double[] nums)
        {
            double total = 0;
            foreach (double number in nums)
            {
                total += number;
            }
            return total;
        }
        public static double Sub(double[] nums)
        {
            double total = nums[0];
            total -= nums[1];
            return total;
        }
        public static double Percent(double Part, double Whole)
        {
            double percent;
            percent = Part / Whole;
            percent *= 100;

            return Math.Round(percent, 2);
        }
        public static double Average(double[] nums)
        {
            double avg = Queryable.Average(nums.AsQueryable());
            return avg;
        }
        public static void resume(string name, string wantedjob, string currentjob, int age, string experience, string edjucation, string skill1, string skill2, int phone, string email)
        {

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(name);
            Console.WriteLine($"age: {age}");
            Console.WriteLine("  ");
            Console.WriteLine("Contact Info");
            Console.WriteLine($"Phone number: {phone}            Email address: {email}");
            Console.WriteLine("  ");
            Console.WriteLine("Experience");
            Console.WriteLine(experience);
            Console.WriteLine("  ");
            Console.WriteLine("Edjucation");
            Console.WriteLine($"I have a {edjucation} edjucation.");
            Console.WriteLine("  ");
            Console.WriteLine("Skills");
            Console.WriteLine($"One skill I have is {skill1}.");
            Console.WriteLine("  ");
            if (skill2 == "none")
            {

            }
            else
            {
                Console.WriteLine($"Another skill I have is {skill2}.");
            }
            Console.WriteLine("  ");


        }
        public static double Power(double number, int expo)
        {
            return Math.Pow(number, expo);
        }
        public static double SciNote(double basenum, int power)
        {
            double answer = basenum * Math.Pow(10, power);
            return answer;
        }
        public static double SqKmtoSqM(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums * exponent;
            return answer;
        }
        public static double SqKmtoSqMi(double nums)
        {
            double answer = nums / 2.59;
            return answer;
        }
        public static double SqKmtoSqYd(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums * 1.196 * exponent;
            return answer;
        }
        public static double SqKmtoSqFt(double nums)
        {
            double exponent = Math.Pow(10, 7);
            double answer = nums * 1.076 * exponent;
            return answer;
        }
        public static double SqKmtoSqIn(double nums)
        {
            double exponent = Math.Pow(10, 9);
            double answer = nums * 1.55 * exponent;
            return answer;
        }
        public static double SqKmtoAcre(double nums)
        {
            double answer = nums * 247.1;
            return answer;
        }
        public static double SqMtoSqKm(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums / exponent;
            return answer;
        }
        public static double SqMtoSqMi(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums / 2.59 * exponent;
            return answer;
        }
        public static double SqMtoSqYd(double nums)
        {
            double answer = nums * 1.196;
            return answer;
        }
        public static double SqMtoSqFt(double nums)
        {
            double answer = nums * 10.764;
            return answer;
        }
        public static double SqMtoSqIn(double nums)
        {
            double answer = nums * 1550;
            return answer;
        }
        // public static double SqMtoHec(double nums)
        // {
        //     double answer = nums / 10000;
        //     return answer;
        // }
        public static double SqMtoAcre(double nums)
        {
            double answer = nums / 4047;
            return answer;
        }
        public static double SqMitoSqKm(double nums)
        {
            double answer = nums * 2.59;
            return answer;
        }
        public static double SqMitoSqM(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums * 2.59 * exponent;
            return answer;
        }
        public static double SqMitoSqYd(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums * 3.098 * exponent;
            return answer;
        }
        public static double SqMitoSqFt(double nums)
        {
            double exponent = Math.Pow(10, 7);
            double answer = nums * 2.788 * exponent;
            return answer;
        }
        public static double SqMitoSqIn(double nums)
        {
            double exponent = Math.Pow(10, 9);
            double answer = nums * 4.014 * exponent;
            return answer;
        }
        public static double SqMitoHec(double nums)
        {
            double answer = nums * 259;
            return answer;
        }
        public static double SqMitoAcre(double nums)
        {
            double answer = nums * 640;
            return answer;
        }
        public static double SqYdtoSqKm(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums / 1.196 * exponent;
            return answer;
        }
        public static double SqYdtoSqM(double nums)
        {
            double answer = nums / 1.196;
            return answer;
        }
        public static double SqYdtoSqMi(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums / 3.098 * exponent;
            return answer;
        }
        public static double SqYdtoSqFt(double nums)
        {
            double answer = nums * 9;
            return answer;
        }
        public static double SqYdtoSqIn(double nums)
        {
            double answer = nums * 1296;
            return answer;
        }
        public static double SqYdtoHec(double nums)
        {
            double answer = nums / 11960;
            return answer;
        }
        public static double SqYdtoAcre(double nums)
        {
            double answer = nums / 4840;
            return answer;
        }
        public static double SqFttoSqKm(double nums)
        {
            double exponent = Math.Pow(10, 7);
            double answer = nums / 1.076 * exponent;
            return answer;
        }
        public static double SqFttoSqM(double nums)
        {
            double answer = nums / 10.764;
            return answer;
        }
        public static double SqFttoSqMi(double nums)
        {
            double exponent = Math.Pow(10, 7);
            double answer = nums / 2.788 * exponent;
            return answer;
        }
        public static double SqFttoSqYd(double nums)
        {
            double answer = nums / 9;
            return answer;
        }
        public static double SqFttoSqIn(double nums)
        {
            double answer = nums * 144;
            return answer;
        }
        public static double SqFttoHec(double nums)
        {
            double answer = nums / 107600;
            return answer;
        }
        public static double SqFttoAcre(double nums)
        {
            double answer = nums / 43560;
            return answer;
        }
        public static double SqIntoSqKm(double nums)
        {
            double exponent = Math.Pow(10, 9);
            double answer = nums / 1.55 * exponent;
            return answer;
        }
        public static double SqIntoSqM(double nums)
        {
            double answer = nums / 1550;
            return answer;
        }
        public static double SqIntoSqMi(double nums)
        {
            double exponent = Math.Pow(10, 9);
            double answer = nums / 4.014 * exponent;
            return answer;
        }
        public static double SqIntoSqYd(double nums)
        {
            double answer = nums / 1296;
            return answer;
        }
        public static double SqIntoSqFt(double nums)
        {
            double answer = nums / 144;
            return answer;
        }
        public static double SqIntoHec(double nums)
        {
            double exponent = Math.Pow(10, 7);
            double answer = nums / 1.55 * exponent;
            return answer;
        }
        public static double SqIntoAcre(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums / 6.273 * exponent;
            return answer;
        }
        
        // public static double HectoSqM(double nums)
        // {
        //     double answer = nums / 10000;
        //     return answer;
        // }
        public static double HectoSqMi(double nums)
        {

            double answer = nums / 259;
            return answer;
        }
        public static double HectoSqYd(double nums)
        {
            double answer = nums / 11960;
            return answer;
        }
        public static double HectoSqFt(double nums)
        {
            double answer = nums * 107600;
            return answer;
        }
        public static double HectoSqIn(double nums)
        {
            double exponent = Math.Pow(10, 7);
            double answer = nums * 1.55 * exponent;
            return answer;
        }
        public static double HectoAcre(double nums)
        {

            double answer = nums * 2.471;
            return answer;
        }
        public static double AcretoSqKm(double nums)
        {
            double answer = nums / 247.1;
            return answer;
        }
        public static double AcretoSqM(double nums)
        {
            double answer = nums * 4046.86;
            return answer;
        }
        public static double AcretoSqMi(double nums)
        {
            double answer = nums / 640;
            return answer;
        }
        public static double AcretoSqYd(double nums)
        {
            double answer = nums * 4840;
            return answer;
        }
        public static double AcretoSqFt(double nums)
        {
            double answer = nums * 43560;
            return answer;
        }
        public static double AcretoSqIn(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums * 6.273 * exponent;
            return answer;
        }
        public static double AcretoHec(double nums)
        {
            double answer = nums / 2.471;
            return answer;
        }
        public static double JtoGc(double nums)
        {
            double answer = nums / 4.184;
            return answer;
        }
        public static double JtoKc(double nums)
        {
            double answer = nums / 4184;
            return answer;
        }
        public static double JtoWzHr(double nums)
        {
            double answer = nums / 3600;
            return answer;
        }
        public static double JtoKwHr(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums / 3.6 * exponent;
            return answer;
        }
        public static double JtoEv(double nums)
        {
            double exponent = Math.Pow(10, 18);
            double answer = nums * 6.242 * exponent;
            return answer;
        }
        public static double JtoBTU(double nums)
        {
            double answer = nums / 1055.055853;
            return answer;
        }
        public static double JtoUST(double nums)
        {
            double exponent = Math.Pow(10, 8);
            double answer = nums / 1.055 * exponent;
            return answer;
        }
        public static double JtoFtLb(double nums)
        {
            double answer = nums / 1.356;
            return answer;
        }
        public static double KjtoGc(double nums)
        {
            double answer = nums * 239.006;
            return answer;
        }
        public static double KjtoKc(double nums)
        {
            double answer = nums / 4.184;
            return answer;
        }
        public static double KjtoWzHr(double nums)
        {
            double answer = nums / 3.6;
            return answer;
        }
        public static double KjtoKwHr(double nums)
        {
            double answer = nums / 3600;
            return answer;
        }
        public static double KjtoEv(double nums)
        {
            double exponent = Math.Pow(10, 21);
            double answer = nums * 6.242 * exponent;
            return answer;
        }
        public static double KjtoBTU(double nums)
        {
            double answer = nums / 1.055;
            return answer;
        }
        public static double KjtoUST(double nums)
        {
            double answer = nums / 105500;
            return answer;
        }
        public static double KjtoFtLb(double nums)
        {
            double answer = nums / 737.6;
            return answer;
        }
        public static double GctoJ(double nums)
        {
            double answer = nums * 4.184;
            return answer;
        }
        public static double GctoKj(double nums)
        {
            double answer = nums / 293;
            return answer;
        }
        public static double GctoWzHr(double nums)
        {
            double answer = nums / 860.4;
            return answer;
        }
        public static double GctoKwHr(double nums)
        {
            double answer = nums / 860400;
            return answer;
        }
        public static double GctoEv(double nums)
        {
            double exponent = Math.Pow(10, 19);
            double answer = nums * 2.611 * exponent;
            return answer;
        }
        public static double GctoBTU(double nums)
        {
            double answer = nums / 252.2;
            return answer;
        }
        public static double GctoUST(double nums)
        {
            double exponent = Math.Pow(10, 7);
            double answer = nums / 2.521 * exponent;
            return answer;
        }
        public static double GctoFtLb(double nums)
        {
            double answer = nums * 3.086;
            return answer;
        }
        public static double KctoJ(double nums)
        {
            double answer = nums * 4184;
            return answer;
        }
        public static double KctoKj(double nums)
        {
            double answer = nums * 4.184;
            return answer;
        }
        public static double KctoWzHr(double nums)
        {
            double answer = nums / 860.4;
            return answer;
        }
        public static double KctoKwHr(double nums)
        {
            double answer = nums / 860400;
            return answer;
        }
        public static double KctoEv(double nums)
        {
            double exponent = Math.Pow(10, 19);
            double answer = nums * 2.611 * exponent;
            return answer;
        }
        public static double KctoBTU(double nums)
        {
            double answer = nums / 252.2;
            return answer;
        }
        public static double KctoUST(double nums)
        {
            double exponent = Math.Pow(10, 7);
            double answer = nums / 2.521 * exponent;
            return answer;
        }
        public static double KctoFtLb(double nums)
        {
            double answer = nums * 3.086;
            return answer;
        }
        public static double WzHrtoJ(double nums)
        {
            double answer = nums * 3600;
            return answer;
        }
        public static double WzHrtoKj(double nums)
        {
            double answer = nums * 3.6;
            return answer;
        }
        public static double WzHrtoGc(double nums)
        {
            double answer = nums * 860.4;
            return answer;
        }
        public static double WzHrtoEv(double nums)
        {
            double exponent = Math.Pow(10, 22);
            double answer = nums * 2.247 * exponent;
            return answer;
        }
        public static double WzHrtoBTU(double nums)
        {
            double answer = nums * 3.412;
            return answer;
        }
        public static double WzHrtoUST(double nums)
        {
            double answer = nums / 29300;
            return answer;
        }
        public static double WzHrtoFtlb(double nums)
        {
            double answer = nums * 2655.22;
            return answer;
        }
        public static double KwHrtoJ(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums * 3.6 * exponent;
            return answer;
        }
        public static double KwHrtoKj(double nums)
        {
            double answer = nums * 3600;
            return answer;
        }
        public static double KwHrtoGc(double nums)
        {
            double answer = nums * 860421;
            return answer;
        }
        public static double KwHrtoKc(double nums)
        {
            double answer = nums * 860.4210028681;
            return answer;
        }
        public static double KwHrtoEv(double nums)
        {
            double exponent = Math.Pow(10, 25);
            double answer = nums * 2.247 * exponent;
            return answer;
        }
        public static double KwHrtoBTU(double nums)
        {
            double answer = nums * 3412.14;
            return answer;
        }
        public static double KwHrtoUST(double nums)
        {
            double answer = nums / 29.3;
            return answer;
        }
        public static double KwHrtoFtLb(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums * 2.655 * exponent;
            return answer;
        }
        public static double EvtoJ(double nums)
        {
            double exponent = Math.Pow(10, 18);
            double answer = nums / 6.242 * exponent;
            return answer;
        }
        public static double EvtoKj(double nums)
        {
            double exponent = Math.Pow(10, 21);
            double answer = nums / 6.242 * exponent;
            return answer;
        }
        public static double EvtoGc(double nums)
        {
            double exponent = Math.Pow(10, 19);
            double answer = nums / 2.611 * exponent;
            return answer;
        }
        public static double EvtoKc(double nums)
        {
            double exponent = Math.Pow(10, 22);
            double answer = nums / 2.611 * exponent;
            return answer;
        }
        public static double EvtoWzHr(double nums)
        {
            double exponent = Math.Pow(10, 22);
            double answer = nums / 2.247 * exponent;
            return answer;
        }
        public static double EvtoKwHr(double nums)
        {
            double exponent = Math.Pow(10, 25);
            double answer = nums / 2.247 * exponent;
            return answer;
        }
        public static double EvtoBTU(double nums)
        {
            double exponent = Math.Pow(10, 21);
            double answer = nums / 6.585 * exponent;
            return answer;
        }
        public static double EvtoUST(double nums)
        {
            double exponent = Math.Pow(10, 26);
            double answer = nums / 6.584 * exponent;
            return answer;
        }
        public static double EvtoFtLb(double nums)
        {
            double exponent = Math.Pow(10, 18);
            double answer = nums / 8.462 * exponent;
            return answer;
        }
        public static double BTUtoJ(double nums)
        {
            double answer = nums * 1055.06;
            return answer;
        }
        public static double BTUtoKj(double nums)
        {
            double answer = nums * 1.05506;
            return answer;
        }
        public static double BTUtoGc(double nums)
        {
            double answer = nums * 252.164;
            return answer;
        }
        public static double BTUtoKc(double nums)
        {
            double answer = nums / 3.966;
            return answer;
        }
        public static double BTUtoWzHr(double nums)
        {
            double answer = nums / 3.412;
            return answer;
        }
        public static double BTUtoKwHr(double nums)
        {
            double answer = nums / 3412.1417;
            return answer;
        }
        public static double BTUtoEv(double nums)
        {
            double exponent = Math.Pow(10, 21);
            double answer = nums * 6.585 * exponent;
            return answer;
        }
        public static double BTUtoUST(double nums)
        {
            double answer = nums / 99980;
            return answer;
        }
        public static double BTUtoFtLb(double nums)
        {
            double answer = nums * 778.169;
            return answer;
        }
        public static double USTtoJ(double nums)
        {
            double exponent = Math.Pow(10, 8);
            double answer = nums * 1.055 * exponent;
            return answer;
        }
        public static double USTtoKj(double nums)
        {
            double answer = nums * 105480;
            return answer;
        }
        public static double USTtoGc(double nums)
        {
            double exponent = Math.Pow(10, 7);
            double answer = nums * 2.521 * exponent;
            return answer;
        }
        public static double USTtoKc(double nums)
        {
            double answer = nums * 25210.4;
            return answer;
        }
        public static double USTtoWzHr(double nums)
        {
            double answer = nums * 29300.1;
            return answer;
        }
        public static double USTtoKwHr(double nums)
        {
            double answer = nums * 29.3001;
            return answer;
        }
        public static double USTtoEv(double nums)
        {
            double exponent = Math.Pow(10, 26);
            double answer = nums * 6.584 * exponent;
            return answer;
        }
        public static double USTtoBTU(double nums)
        {
            double answer = nums * 99976.1;
            return answer;
        }
        public static double USTtoFtLb(double nums)
        {
            double exponent = Math.Pow(10, 7);
            double answer = nums * 7.78 * exponent;
            return answer;
        }
        public static double FtLbtoJ(double nums)
        {
            double answer = nums * 1.35582;
            return answer;
        }
        public static double FtLbtoKj(double nums)
        {
            double answer = nums / 737.562;
            return answer;
        }
        public static double FtLbtoGc(double nums)
        {
            double answer = nums / 3.086;
            return answer;
        }
        public static double FtLbtoKc(double nums)
        {
            double answer = nums / 3086;
            return answer;
        }
        public static double FtLbtoWzHr(double nums)
        {
            double answer = nums / 2655;
            return answer;
        }
        public static double FtLbtoKwHr(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums / 2.655 * exponent;
            return answer;
        }
        public static double FtLbtoEv(double nums)
        {
            double exponent = Math.Pow(10, 18);
            double answer = nums * 8.462 * exponent;
            return answer;
        }
        public static double FtLbtoBTU(double nums)
        {
            double answer = nums / 778.2;
            return answer;
        }
        public static double FtLbtoUST(double nums)
        {
            double exponent = Math.Pow(10, 7);
            double answer = nums / 7.78 * exponent;
            return answer;
        }
        public static double HztoMHz(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums * exponent;
            return answer;
        }
        public static double HztoGHz(double nums)
        {
            double exponent = Math.Pow(10, 9);
            double answer = nums * exponent;
            return answer;
        }
        public static double KHztoGHz(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums / exponent;
            return answer;
        }
        public static double MHztoHz(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums * exponent;
            return answer;
        }
        public static double GHztoHz(double nums)
        {
            double exponent = Math.Pow(10, 9);
            double answer = nums * exponent;
            return answer;
        }
        public static double GHztoKHz(double nums)
        {
            double exponent = Math.Pow(10, 6);
            double answer = nums * exponent;
            return answer;
        }
        public static double KmtoCm(double nums)
        {
            double answer = nums * 100000;
            return answer;
        }
        public static double KmtoMm(double nums)
        {
            double answer = nums * Math.Pow(10, 6);
            return answer;
        }
        public static double KmtoMicroM(double nums)
        {
            double answer = nums * Math.Pow(10, 12);
            return answer;
        }
        public static double KmtoNm(double nums)
        {
            double answer = nums * Math.Pow(10, 12);
            return answer;
        }
        public static double KmtoMi(double nums)
        {
            double answer = nums / 1.609;
            return answer;
        }
        public static double KmtoYd(double nums)
        {
            double answer = nums * 1093.61;
            return answer;
        }
        public static double KmtoFt(double nums)
        {
            double answer = nums * 3280.84;
            return answer;
        }
        public static double KmtoIn(double nums)
        {
            double answer = nums * 39370.1;
            return answer;
        }
        public static double KmtoNautMi(double nums)
        {
            double answer = nums / 1.852;
            return answer;
        }
        public static double MtoMm(double nums)
        {
            double answer = nums * Math.Pow(10, 6);
            return answer;
        }
        public static double MtoMicroM(double nums)
        {
            double answer = nums * Math.Pow(10, 6);
            return answer;
        }
        public static double MtoNm(double nums)
        {
            double answer = nums * Math.Pow(10, 9);
            return answer;
        }
        public static double MtoMi(double nums)
        {
            double answer = nums / 1609;
            return answer;
        }
        public static double MtoYd(double nums)
        {
            double answer = nums * 1.09361;
            return answer;
        }
        public static double MtoFt(double nums)
        {
            double answer = nums * 3.28084;
            return answer;
        }
        public static double MtoIn(double nums)
        {
            double answer = nums * 39.3701;
            return answer;
        }
        public static double MtoNautMi(double nums)
        {
            double answer = nums / 1852;
            return answer;
        }
        public static double CmtoKm(double nums)
        {
            double answer = nums / 100000;
            return answer;
        }
        // public static double CmtoMicroM(double nums)
        // {
        //     double answer = nums * 10000;
        //     return answer;
        // }
        public static double CmtoNm(double nums)
        {
            double answer = nums * Math.Pow(10, 7);
            return answer;
        }
        public static double CmtoMi(double nums)
        {
            double answer = nums / 160900;
            return answer;
        }
        public static double CmtoYd(double nums)
        {
            double answer = nums / 91.44;
            return answer;
        }
        public static double CmtoFt(double nums)
        {
            double answer = nums / 30.48;
            return answer;
        }
        public static double CmtoIn(double nums)
        {
            double answer = nums / 2.54;
            return answer;
        }
        public static double CmtoNautMi(double nums)
        {
            double answer = nums / 185200;
            return answer;
        }
        public static double MmtoKm(double nums)
        {
            double answer = nums / Math.Pow(10, 6);
            return answer;
        }
        public static double MmtoNm(double nums)
        {
            double answer = nums * Math.Pow(10, 9);
            return answer;
        }
        public static double MmtoMi(double nums)
        {
            double answer = nums / 1.609 * Math.Pow(10, 6);
            return answer;
        }
        public static double xten(double nums)
        {
            double answer = nums * 10;
            return answer;
        }
        public static double xonehundo(double nums)
        {
            double answer = nums * 100;
            return answer;
        }
        public static double xthousand(double nums)
        {
            double answer = nums * 1000;
            return answer;
        }
        public static double xtenthousand(double nums)
        {
            double answer = nums * 10000;
            return answer;
        }
        public static double xhundothousand(double nums)
        {
            double answer = nums * 100000;
            return answer;
        }
        
        public static double Dten(double nums)
        {
            double answer = nums / 10;
            return answer;
        }
        public static double Dhundo(double nums)
        {
            double answer = nums / 100;
            return answer;
        }
        public static double Dthousand(double nums)
        {
            double answer = nums / 1000;
            return answer;
        }
        public static double Dtenthousand(double nums)
        {
            double answer = nums / 10000;
            return answer;
        }
        public static double SqRt(double num)
        {
            return Math.Sqrt(num);
        }
    }   
}