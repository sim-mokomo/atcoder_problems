using System;

namespace ABC001
{
    public class ABC001_B
    {
//        static void Main(string[] args)
//        {
//            ABC001_B instance = new ABC001_B();
//            instance.Answer();
//        }

        private void Answer()
        {
            int m = int.Parse(Console.ReadLine());
            string vv = Convert2VV(m);
            Console.WriteLine(vv);
        }

        private string Convert2VV(int viewDistance)
        {
            var kmViewDistance = viewDistance * 0.001;
            
            if (kmViewDistance > 70)
            {
                return "89";
            }

            if (kmViewDistance >= 35)
            {
                kmViewDistance -= 30;
                kmViewDistance /= 5;
                kmViewDistance += 80;
                return valueVV2VVStringFormat(kmViewDistance);
            }

            if (kmViewDistance >= 6)
            {
                kmViewDistance += 50;
                return valueVV2VVStringFormat(kmViewDistance);
            }

            if (kmViewDistance >= 0.1)
            {
                kmViewDistance *= 10;
                return valueVV2VVStringFormat(kmViewDistance);
            }

            return "00";
        }

        private string valueVV2VVStringFormat(double VV)
        {
            VV = (int) VV;
            return VV.ToString().PadLeft(totalWidth: 2, paddingChar: '0');
        }
    }
}