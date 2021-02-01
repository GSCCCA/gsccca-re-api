using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    public enum PRIA_RecordableDocumentTypeEnumerated
    {

        AnyRealEstate = 0,

        /// <remarks/>
        AbstractOfJudgment = 1,

        /// <remarks/>
        AffadavitOfDeath = 2,

        /// <remarks/>
        Assignment = 3,

        /// <remarks/>
        AssignmentOfMortgage = 4,

        /// <remarks/>
        AssignmentOfDeedOfTrust = 5,

        /// <remarks/>
        BargainAndSaleDeed = 6,

        /// <remarks/>
        BlanketAssignment = 7,

        /// <remarks/>
        Deed = 8,

        /// <remarks/>
        DeedOfTrust = 9,

        /// <remarks/>
        FederalTaxLien = 10,

        /// <remarks/>
        Judgment = 11,

        /// <remarks/>
        ModificationAgreementOrConsolidationAgreement = 12,

        /// <remarks/>
        Mortgage = 13,

        /// <remarks/>
        Other = 14,

        /// <remarks/>
        PartialSatisfactionOfLien = 15,

        /// <remarks/>
        PowerOfAttorney = 16,

        /// <remarks/>
        QuitClaimDeed = 17,

        /// <remarks/>
        Reconveyance = 18,

        /// <remarks/>
        ReleaseOfLien = 19,

        /// <remarks/>
        ReleaseOfFederalTaxLien = 20,

        /// <remarks/>
        ReleaseOfStateTaxLien = 21,

        /// <remarks/>
        ReleaseOfTreasurersTaxLien = 22,

        /// <remarks/>
        SatisfactionOfLien = 23,

        /// <remarks/>
        SatisfactionOfMortgage = 24,

        /// <remarks/>
        SecurityInstrument = 25,

        /// <remarks/>
        SignatureAffidavit = 26,

        /// <remarks/>
        StateTaxLien = 27,

        /// <remarks/>
        SubordinateLienAgreement = 28,

        /// <remarks/>
        SubstitutionOfTrustee = 29,

        /// <remarks/>
        TreasurersTaxLien = 30,

        /// <remarks/>
        WarrantyDeed = 31,

        Satisfaction = 32,   // had to be added to keep INGEO XML sample from crashing on deserialization

        Plat = 33, // Plats added as available for submission in Real Estate Packages

        Lien = 34, // Liens added as available for submission in Real Estate Packages
    }
}
