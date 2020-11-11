using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
    public class BL:IBL
    {
        IDAL dal = new DAL.DAL();
        #region TERMS
        public IEnumerable<string> GetTermsTitles()
        {
            return dal.GetTermsTitles();
        }
        public IEnumerable<Term> GetTerms()
        {
            return dal.GetTerms();
        }

        public Term GetTermById(int? id)
        {
            return dal.GetTermById(id);
        }
        public void AddTerm(Term term)
        {
            dal.AddTerm(term);
        }

        public void DeleteTerm(int id)
        {
            dal.DeleteTerm(id);
        }
        public void UpdateTerm(Term term)
        {
            dal.UpdateTerm(term);
        }


        #endregion
        #region QandAs
        public IEnumerable<QandA> GetQandAs()
        {
            return dal.GetQandAs();
        }
        public IEnumerable<QandA> FilterQandAsByFirstLetter(char letter)
        {
            return dal.FilterQandAsByFirstLetter(letter);
        }
        public QandA GetQandAById(int? id)
        {
            return dal.GetQandAById(id);
        }
        public void AddQandA(QandA qandA)
        {
            dal.AddQandA(qandA);
        }

        public void DeleteQandA(int id)
        {
            dal.DeleteQandA(id);
        }
        public void UpdateQandA(QandA qandA)
        {
            dal.UpdateQandA(qandA);
        }

        #endregion
        #region LEGISLATIONS
        public IEnumerable<legislation> GetLegislations()
        {
            return dal.GetLegislations();
        }
        public legislation GetLegislationById(int? id)
        {
            return dal.GetLegislationById(id);
        }
        public void AddLegislation(legislation legislation)
        {
            dal.AddLegislation(legislation);
        }

        public void DeleteLegislation(int id)
        {
            dal.DeleteLegislation(id);
        }
        public void UpdateLegislation(legislation legislation)
        {
            dal.UpdateLegislation(legislation);
        }
        #endregion
        #region VERDICTS
        public IEnumerable<Verdict> GetVerdicts()
        {
            return dal.GetVerdicts();
        }

        public Verdict GetVerdictById(int? id)
        {
            return dal.GetVerdictById(id);
        }

        public void AddVerdict(Verdict verdict)
        {
            dal.AddVerdict(verdict);
        }

        public void DeleteVerdict(int id)
        {
            dal.DeleteVerdict(id);
        }


        public void UpdateVerdict(Verdict verdict)
        {
            dal.UpdateVerdict(verdict);
        }


        #endregion
    }
}
