using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace BL
{
    public interface IBL
    {
        #region TERMS
        IEnumerable<Term> GetTerms();
        Term GetTermById(int? id);
        void AddTerm(Term term);
        void DeleteTerm(int id);
        void UpdateTerm(Term term);
        IEnumerable<string> GetTermsTitles();

        #endregion
        #region QandAs
        IEnumerable<QandA> GetQandAs();
        IEnumerable<QandA> FilterQandAsByFirstLetter(char letter);
        QandA GetQandAById(int? id);
        void AddQandA(QandA qandA);
        void DeleteQandA(int id);
        void UpdateQandA(QandA qandA);

        #endregion
        #region LEGISLATIONS
        IEnumerable<legislation> GetLegislations();
        legislation GetLegislationById(int? id);
        void AddLegislation(legislation legislation);
        void DeleteLegislation(int id);
        void UpdateLegislation(legislation legislation);

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
