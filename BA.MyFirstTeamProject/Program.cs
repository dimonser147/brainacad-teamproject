using BA.MyFirstTeamProject.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.MyFirstTeamProject.Utilities;

namespace BA.MyFirstTeamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: 1. create students manager
            IStudentsManager StudentsManager = new FakeStudentsManager();
            // TODO: 2. create appropriate students collection and fill it by other students
            IList<IStudent> students = new List<IStudent>();
            IStudent VladTk = new TkachenkoVlad();
            IStudent maxPrs = new MaksymPereshybkin();
            IStudent antonPluzhnikov = new AntonPluzhnikov();
            IStudent ivanSakharchuk = new IvanSakharchuk();
            IStudent igorAlborov = new IgorAlborovStudent();
            IStudent alkovychSerhii = new AlkovychSerhii();
            students.Add(antonPluzhnikov);
            students.Add(ivanSakharchuk);
            students.Add(igorAlborov);
            students.Add(new YurySviridov());
            students.Add(new PetroReznikStudent());
            students.Add(new AndreyDzyuba());
            students.Add(VladTk);
            students.Add(new OleksiiGorishnii());            
            students.Add(new AndreiMatveev());
            students.Add(new YevhenKhatylaiev());
            students.Add(new VasiliyCherniatyn());
            students.Add(new GlushenkoBorys());
            students.Add(new VadikKorzh());
            students.Add(new AlkovychSerhii());
            students.Add(maxPrs);
            // TODO: 3. print marks of all students
            foreach (var item in students)
            {
                Console.WriteLine(item.ToMarkString(StudentsManager.GetMark(item)));
            }
            Console.WriteLine(students.Count);
            Console.ReadLine();
        }
    }
}
