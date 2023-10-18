namespace PMPHF005_NLUG4F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0, B = 0, C = 0, D = 0;
            int n = File.ReadAllLines("input.txt").Length;
            string[] muveletek = new string[n-1];

            FileStream f = new FileStream("input.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f);

            string[] seged = sr.ReadLine().Split(",");
            A = int.Parse(seged[0]);
            B = int.Parse(seged[1]);
            C = int.Parse(seged[2]);
            D = int.Parse(seged[3]);

            //A - 65; B - 66; C - 67; D - 68
            int k = 0;
            while (!sr.EndOfStream)
            {
                muveletek[k] = sr.ReadLine();
                k++;
            }
            sr.Close();
            f.Close();

            k = 0;
            while (k != n-1)
            {
                string[] sor = muveletek[k].Split(" ");
                k++;
                if (sor[0] == "MOV")
                {
                    char one = sor[1][0];
                    char two = sor[2][0];

                    //A
                    if ((int)one == 65)
                    {
                        //B
                        if ((int)two == 66)
                        {
                            A = B;
                        }
                        //C
                        else if ((int)two == 67)
                        {
                            A = C;
                        }
                        //D
                        else if ((int)two == 68)
                        {
                            A = D;
                        }
                        else
                        {
                            A = int.Parse(sor[2]);
                        }
                    }
                    //B
                    else if ((int)one == 66)
                    {
                        //A
                        if ((int)two == 65)
                        {
                            B = A;
                        }
                        //C
                        else if ((int)two == 67)
                        {
                            B = C;
                        }
                        //D
                        else if ((int)two == 68)
                        {
                            B = D;
                        }
                        else
                        {
                            B = int.Parse(sor[2]);
                        }
                    }
                    //C
                    else if ((int)one == 67)
                    {
                        //A
                        if ((int)two == 65)
                        {
                            C = A;
                        }
                        //B
                        else if ((int)two == 66)
                        {
                            C = B;
                        }
                        //D
                        else if ((int)two == 68)
                        {
                            C = D;
                        }
                        else
                        {
                            C = int.Parse(sor[2]);
                        }
                    }
                    //D
                    else if ((int)one == 68)
                    {
                        //A
                        if ((int)two == 65)
                        {
                            D = A;
                        }
                        //B
                        else if ((int)two == 66)
                        {
                            D = B;
                        }
                        //C
                        else if ((int)two == 67)
                        {
                            D = C;
                        }
                        else
                        {
                            D = int.Parse(sor[2]);
                        }
                    }
                }
                else if (sor[0] == "ADD")
                {
                    char one = sor[1][0];
                    char two = sor[2][0];
                    char third = sor[3][0];

                    int elso = 0;
                    int masodik = 0;
                    //elso valtozo
                    //A
                    if ((int)two == 65)
                    {
                        elso = A;
                    }
                    //B
                    else if ((int)two == 66)
                    {
                        elso = B;
                    }
                    //C
                    else if ((int)two == 67)
                    {
                        elso = C;
                    }
                    //D
                    else if ((int)two == 68)
                    {
                        elso = D;
                    }
                    else
                    {
                        elso = int.Parse(sor[2]);
                    }

                    //masodik valtozo
                    //A
                    if ((int)third == 65)
                    {
                        masodik = A;
                    }
                    //B
                    else if ((int)third == 66)
                    {
                        masodik = B;
                    }
                    //C
                    else if ((int)third == 67)
                    {
                        masodik = C;
                    }
                    //D
                    else if ((int)third == 68)
                    {
                        masodik = D;
                    }
                    else
                    {
                        masodik = int.Parse(sor[3]);
                    }

                    //A
                    if ((int)one == 65)
                    {
                        A = elso + masodik;
                    }
                    //B
                    else if ((int)one == 66)
                    {
                        B = elso + masodik;
                    }
                    //C
                    else if ((int)one == 67)
                    {
                        C = elso + masodik;
                    }
                    //D
                    else if ((int)one == 68)
                    {
                        D = elso + masodik;
                    }
                }
                else if (sor[0] == "SUB")
                {
                    char one = sor[1][0];
                    char two = sor[2][0];
                    char third = sor[3][0];

                    int elso = 0;
                    int masodik = 0;
                    //elso valtozo
                    //A
                    if ((int)two == 65)
                    {
                        elso = A;
                    }
                    //B
                    else if ((int)two == 66)
                    {
                        elso = B;
                    }
                    //C
                    else if ((int)two == 67)
                    {
                        elso = C;
                    }
                    //D
                    else if ((int)two == 68)
                    {
                        elso = D;
                    }
                    else
                    {
                        elso = int.Parse(sor[2]);
                    }

                    //masodik valtozo
                    //A
                    if ((int)third == 65)
                    {
                        masodik = A;
                    }
                    //B
                    else if ((int)third == 66)
                    {
                        masodik = B;
                    }
                    //C
                    else if ((int)third == 67)
                    {
                        masodik = C;
                    }
                    //D
                    else if ((int)third == 68)
                    {
                        masodik = D;
                    }
                    else
                    {
                        masodik = int.Parse(sor[3]);
                    }

                    //A
                    if ((int)one == 65)
                    {
                        A = elso - masodik;
                    }
                    //B
                    else if ((int)one == 66)
                    {
                        B = elso - masodik;
                    }
                    //C
                    else if ((int)one == 67)
                    {
                        C = elso - masodik;
                    }
                    //D
                    else if ((int)one == 68)
                    {
                        D = elso - masodik;
                    }
                }
                else if (sor[0] == "JNE")
                {
                    char one = sor[1][0];
                    char two = sor[2][0];
                    char third = sor[3][0];

                    int s = 0;
                    if ((int)one > 68 || (int)one < 65)
                    {
                        s = int.Parse(sor[1]);
                    }

                    int elso = 0;
                    int masodik = 0;
                    //elso valtozo
                    //A
                    if ((int)two == 65)
                    {
                        elso = A;
                    }
                    //B
                    else if ((int)two == 66)
                    {
                        elso = B;
                    }
                    //C
                    else if ((int)two == 67)
                    {
                        elso = C;
                    }
                    //D
                    else if ((int)two == 68)
                    {
                        elso = D;
                    }
                    else
                    {
                        elso = int.Parse(sor[2]);
                    }

                    //masodik valtozo
                    //A
                    if ((int)third == 65)
                    {
                        masodik = A;
                    }
                    //B
                    else if ((int)third == 66)
                    {
                        masodik = B;
                    }
                    //C
                    else if ((int)third == 67)
                    {
                        masodik = C;
                    }
                    //D
                    else if ((int)third == 68)
                    {
                        masodik = D;
                    }
                    else
                    {
                        masodik = int.Parse(sor[3]);
                    }

                    if (elso != masodik)
                    {
                        k = s;
                    }
                }
            }

            FileStream f2 = new FileStream("output.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f2);

            sw.WriteLine(A + "," + B + "," + C + "," + D);

            sw.Close();
            f2.Close();
        }
    }
}