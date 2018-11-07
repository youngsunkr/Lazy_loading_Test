using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredLoadingEnabled
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IEnumerable<Entity> entity = new IEnumerable<Entity>();
            entity.authors[1].
            //entity[0].au_fname.au_fname;

            var items = (from x in entity.authors

                         where x.au_fname.StartsWith(fname)

                         select x).Take(2);



            Console.WriteLine("SubSet 탐색 – 명지적 로딩");

            foreach (authors item in items)

            {

                if (item.au_id == "213-46-8915")

                {

                    if (!item.titleauthor.IsLoaded)

                        item.titleauthor.Load();



                    foreach (var titleAu in item.titleauthor)

                    {

                        if (titleAu != null)

                            Console.WriteLine("{0} : {1} : {2}"

                                , titleAu.authors.au_fname, titleAu.au_id, titleAu.au_ord);

                    }

                }

                else

                {

                    foreach (var titleAu in item.titleauthor)

                    {

                        if (titleAu != null)

                            Console.WriteLine("{0} : {1} : {2}"

                                , titleAu.authors.au_fname, titleAu.au_id, titleAu.au_ord);

                    }

                }

            }
            */

        }
    }

    public class Entity
    {
        public string authors;
        public string au_fname = string.Empty;
    }
}
