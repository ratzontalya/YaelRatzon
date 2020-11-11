using BE;
using Lawyer.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL : IDAL
    {
        #region TERMS
        public IEnumerable<Term> GetTerms() {
            List<Term> result = new List<Term>();  
            using(var db = new QandAContext())
            {
                foreach (var item in db.Terms)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public Term GetTermById(int? id)
        {
            Term result = new Term();
            using (var db = new QandAContext())
            {
                foreach (var item in db.Terms)
                {
                    if(item.ID == id)
                        result = item;
                }
            }
            return result;
        }
        public void AddTerm(Term term)
        {
            using (var db = new QandAContext())
            {
                db.Terms.Add(term);
                db.SaveChanges();
            }
        }
        public void DeleteTerm(int id)
        {
            using (var db = new QandAContext())
            {
                var result = db.Terms.Find(id);
                db.Terms.Remove(result);
                db.SaveChanges();
            }
        }

        public void UpdateTerm(Term term)
        {
            using (var db = new TermContext())
            {
                db.Entry(term).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public IEnumerable<string> GetTermsTitles()
        {
            List<string> result = new List<string>();
            using (var db = new QandAContext())
            {
                foreach (var item in db.Terms)
                {
                    result.Add(item.Title);
                }
            }
            return result;
        }

        #endregion
        #region QandAs
        public IEnumerable<QandA> GetQandAs() {
            List<QandA> result = new List<QandA>();
            using (var db = new QandAContext())
            {
                foreach (var item in db.QandAs)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public IEnumerable<QandA> FilterQandAsByFirstLetter(char letter) {
            List<QandA> result = new List<QandA>();
            using (var db = new QandAContext())
            {
                foreach (var item in db.QandAs)
                {
                    if(item.Title[0] == letter)
                        result.Add(item);
                }
            }
            return result;
        }
        public QandA GetQandAById(int? id)
        {
            QandA result = new QandA();
            using (var db = new QandAContext())
            {
                foreach (var item in db.QandAs)
                {
                    if (item.ID == id)
                        result = item;
                }
            }
            return result;
        }

        public void AddQandA(QandA qandA)
        {
            using (var db = new QandAContext())
            {
                db.QandAs.Add(qandA);
                db.SaveChanges();
            }
        }

        public void DeleteQandA(int id)
        {
            using (var db = new QandAContext())
            {
                var result = db.QandAs.Find(id);
                db.QandAs.Remove(result);
                db.SaveChanges();
            }
        }
        public void UpdateQandA(QandA qandA)
        {
            using (var db = new QandAContext())
            {
                db.Entry(qandA).State = EntityState.Modified;
                db.SaveChanges();
            }
        }



        #endregion
        #region LEGISLATIONS
        public IEnumerable<legislation> GetLegislations() {
            List<legislation> result = new List<legislation>();
            using (var db = new legislationContext())
            {
                foreach (var item in db.legislations)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public legislation GetLegislationById(int? id)
        {
            legislation result = new legislation();
            using (var db = new legislationContext())
            {
                foreach (var item in db.legislations)
                {
                    if (item.ID == id)
                        result = item;
                }
            }
            return result;
        }

        public void AddLegislation(legislation legislation)
        {
            using (var db = new legislationContext())
            {
                db.legislations.Add(legislation);
                db.SaveChanges();
            }
        }

        public void DeleteLegislation(int id)
        {
            using (var db = new legislationContext())
            {
                var result = db.legislations.Find(id);
                db.legislations.Remove(result);
                db.SaveChanges();
            }
        }
        public void UpdateLegislation(legislation legislation)
        {
            using (var db = new legislationContext())
            {
                db.Entry(legislation).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        #endregion
        #region VERDICTS
        public IEnumerable<Verdict> GetVerdicts() {
            List<Verdict> result = new List<Verdict>();
            using (var db = new VerdictContext())
            {
                foreach (var item in db.Verdicts)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public Verdict GetVerdictById(int? id)
        {
            Verdict result = new Verdict();
            using (var db = new VerdictContext())
            {
                foreach (var item in db.Verdicts)
                {
                    if (item.ID == id)
                        result = item;
                }
            }
            return result;
        }



        public void AddVerdict(Verdict verdict)
        {
            using (var db = new VerdictContext())
            {
                db.Verdicts.Add(verdict);
                db.SaveChanges();
            }
        }

        public void DeleteVerdict(int id)
        {
            using (var db = new VerdictContext())
            {
                var result = db.Verdicts.Find(id);
                db.Verdicts.Remove(result);
                db.SaveChanges();
            }
        }

        public void UpdateVerdict(Verdict verdict)
        {
            using (var db = new VerdictContext())
            {
                db.Entry(verdict).State = EntityState.Modified;
                db.SaveChanges();
            }
        }


        #endregion
    }
}
