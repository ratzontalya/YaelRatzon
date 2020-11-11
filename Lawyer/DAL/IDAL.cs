using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        #region TERMS
        IEnumerable<Term> GetTerms();
        Term GetTermById(int? id);
        void AddTerm(Term term);
        void UpdateTerm(Term term);
        void DeleteTerm(int id);
        IEnumerable<string> GetTermsTitles();
        #endregion
        #region QandAs
        IEnumerable<QandA> GetQandAs();
        IEnumerable<QandA> FilterQandAsByFirstLetter(char letter);
        QandA GetQandAById(int? id);
        void AddQandA(QandA qandA);
        void UpdateQandA(QandA qandA);
        void DeleteQandA(int id);

        #endregion
        #region LEGISLATIONS
        IEnumerable<legislation> GetLegislations();
        legislation GetLegislationById(int? id);
        void AddLegislation(legislation legislation);
        void UpdateLegislation(legislation legislation);
        void DeleteLegislation(int id);

        #endregion
        #region VERDICTS
        IEnumerable<Verdict> GetVerdicts();
        Verdict GetVerdictById(int? id);
        void AddVerdict(Verdict verdict);
        void DeleteVerdict(int id);
        void UpdateVerdict(Verdict verdict);
        #endregion
    }
}
