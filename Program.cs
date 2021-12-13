using System;
using System.Collections.Generic;
using System.Linq;

namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {
           List<person> employ = new list<person>();
            
           person p1 = new person();
           p1.Name = "ali";
           p1.Family = "alimi";
           p1.Age =40;
           p1.Jensiat = "mard";
           p1.Salary =35000000;
           p1.Position = "moaven";
           employ.Add(p1); 

           person p2 = new person(){
               Name="roya", Family="kazemi", Age = 38, Jensiat = "mard", Salary = 20000000, Position ="hesabdar",
           };
           employ.Add(p2);

           person p3 = new person(){
               Name = "rana", Family="rezayi", Age = 45, Jensiat ="zan", Salary = 12000000, Position ="karmand",
           };
           employ.Add(p3);

           person p4 = new person(){
               Name ="hamed", Family ="kamyar", Age=46, Jensiat="mard", Salary =45000000, Position="programer",
           };
           employ.Add(p4);
           
            //age over>40 
            System.Console.WriteLine("*****karmandan balaye 40sal*****");
            var result1 = employ.Where(s => s.Age>40).OrderByDescending( s=>s.Age).ToArray();          
          
           foreach (var s in result1)
           {   
               System.Console.WriteLine(s);
              
               System.Console.WriteLine($"name:{s.Name}  family: {s.Family}  age : {s.Age}");
           }
            foreach (var item in employ)
            {
                
                System.Console.WriteLine("--------");
            }
                 
           // 10000000<salary beetween<13000000
           System.Console.WriteLine("******hoghug beyn 10 melyun va 13melyun****");
           var result2 = employ.Where(a=>a.Salary>10000000 && a.Salary<13000000).ToList();

           foreach (var a in result2 ){

               
                System.Console.WriteLine(a);
               System.Console.WriteLine($"name:{a.Name}  family: {a.Family} salary : {a.Salary}");
           }
           foreach (var item in employ)
            {
                
                System.Console.WriteLine("--------");
            }
         
            //salary<30000000 && jensiat=zan 
            System.Console.WriteLine("******karmandan zan va hoghuge kamtar az 30000000*****");     
          var result3 = employ.Where(b=>b.Salary<3000000 && b.Jensiat=="zan").ToList();
          foreach (var b in result3)
          {
              
              System.Console.WriteLine(b);
              System.Console.WriteLine($"name:{b.Name} family:{b.Family} salary : {b.Salary} jensiat :{b.Jensiat}");
          }
          foreach (var item in employ)
            {
                
                System.Console.WriteLine("---------");
            }

           System.Console.WriteLine("******jamee hoghuge mahiyane kole karmandan*****");
            var sumresult4 = employ.Sum(c=>c.Salary);
            System.Console.WriteLine(sumresult4);
            foreach (var item in employ)
            {
                
                System.Console.WriteLine("--------");
            }

          System.Console.WriteLine("******miangin hoghoge karmandan mard****");
          var maleresult5 = employ.Where(d=>d.Jensiat == "mard");
          var avgSalary = maleresult5.Average(d=>d.Salary);
          System.Console.WriteLine(avgSalary);
          foreach (var item in employ)
            {
                
                System.Console.WriteLine("--------");
            }
         

          System.Console.WriteLine("******miangin senni karmandan*****");
          var avgMale_Age = maleresult5.Average(m=>m.Age);
          System.Console.WriteLine(avgMale_Age);
          foreach (var item in employ)
            {
                
                System.Console.WriteLine("--------");
            }
          System.Console.WriteLine("******jaygahe fardi ke bishtarin hoghug ro migire*****");
          var maxresult6 =employ.Where(k=>k.Salary==45000000 && k.Position=="programer").ToList();
           foreach (var k in maxresult6 ){

               
                System.Console.WriteLine(k);
               System.Console.WriteLine($"name:{k.Name}  family: {k.Family} salary : {k.Salary}");
           }
           foreach (var item in employ)
            {
                
                System.Console.WriteLine("--------");
            }
         
          System.Console.WriteLine("******jaygahe fardi ke kamtarin hoghug ro migire*****");
          var minresult6 = employ.Where(k=>k.Salary==12000000 && k.Position=="karmand").ToList();
           foreach (var k in minresult6 ){

                System.Console.WriteLine(k);
                
               System.Console.WriteLine($"name:{k.Name}  family: {k.Family} salary : {k.Salary}");
           }
         
            


           

           
           



        }
    }
}
