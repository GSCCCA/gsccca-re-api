using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSCCCA.RealEstate
{
    /// <summary>
    /// Represents a Party associated with a filing
    /// </summary>
    public class FilingParty
    {
        private string name = string.Empty;
        private string city = string.Empty;
        private string address1 = string.Empty;
        private string address2 = string.Empty;
        private string state = string.Empty;
        private string postalCode = string.Empty;
        private string identifier = "";
        private bool nonPersonEntity = false;

        /// <summary>
        /// Gets/sets the name of the person
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets/sets a value indicating whether or not the party is a non-person entity
        /// </summary>
        public bool NonPersonEntity
        {
            get { return this.nonPersonEntity; }
            set { this.nonPersonEntity = value; }
        }

        /// <summary>
        /// Gets/sets the City of the person's address
        /// </summary>
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        /// <summary>
        /// Gets/sets the First line of the street address of the person's address
        /// </summary>
        public string Address1
        {
            get { return this.address1; }
            set { this.address1 = value; }
        }
        /// <summary>
        /// Gets/sets the Second line of the street address of the person's address
        /// </summary>
        public string Address2
        {
            get { return this.address2; }
            set { this.address2 = value; }
        }
        /// <summary>
        /// Gets/sets the State of the person's address
        /// </summary>
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }
        /// <summary>
        /// Gets/sets the Postal Code of the person's address
        /// </summary>
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        /// <summary>
        /// Gets/sets a string that identifies the person
        /// </summary>
        public string Identifier
        {
            get { return this.identifier; }
            set { this.identifier = value; }
        }

        /// <summary>
        /// Converts a FilingParty into a strongly types Pria Grantee
        /// </summary>
        /// <returns>A PRIA_GRANTEE_TYPE object</returns>
        internal PRIALibraryV24.PRIA_GRANTEE_Type ToPriaGrantee()
        {
            PRIALibraryV24.PRIA_GRANTEE_Type g = new PRIALibraryV24.PRIA_GRANTEE_Type();

            g._StreetAddress = this.address1;
            g._StreetAddress2 = this.address2;
            g._City = this.city;
            g._ID = this.identifier;
            g._PostalCode = this.postalCode;
            g._State = this.state;
            g._UnparsedName = this.name;

            if (this.nonPersonEntity)
                g.NonPersonEntityIndicator = "Y";

            return g;
        }

        /// <summary>
        /// Converts a FilingParty into a strongly types Pria Grantor
        /// </summary>
        /// <returns>A PRIA_GRANTOR_TYPE object</returns>
        internal PRIALibraryV24.PRIA_GRANTOR_Type ToPriaGrantor()
        {
            PRIALibraryV24.PRIA_GRANTOR_Type g = new PRIALibraryV24.PRIA_GRANTOR_Type();

            g._StreetAddress = this.address1;
            g._StreetAddress2 = this.address2;
            g._City = this.city;
            g._ID = this.identifier;
            g._PostalCode = this.postalCode;
            g._State = this.state;
            g._UnparsedName = this.name;

            if (this.nonPersonEntity)
                g.NonPersonEntityIndicator = "Y";

            return g;
        }

        /// <summary>
        /// Creates a FilingParty from a strongly typed Pria Grantor
        /// </summary>
        /// <returns>A FilingParty Object</returns>
        internal static FilingParty FromPriaGrantor(PRIALibraryV24.PRIA_GRANTOR_Type g)
        {
            FilingParty p = new FilingParty();
            p.Address1 = g._StreetAddress;
            p.Address2 = g._StreetAddress2;
            p.City = g._City;
            p.Identifier = g._ID;
            p.PostalCode = g._PostalCode;
            p.State = g._State;
            p.Name = g._UnparsedName;

            if (!string.IsNullOrEmpty(g.NonPersonEntityIndicator) && g.NonPersonEntityIndicator.ToUpper() == "Y")
                p.nonPersonEntity = true;

            return p;
        }

        /// <summary>
        /// Creates a FilingParty from a strongly typed Pria Grantee
        /// </summary>
        /// <returns>A FilingParty Object</returns>
        internal static FilingParty FromPriaGrantee(PRIALibraryV24.PRIA_GRANTEE_Type g)
        {
            FilingParty p = new FilingParty();
            p.Address1 = g._StreetAddress;
            p.Address2 = g._StreetAddress2;
            p.City = g._City;
            p.Identifier = g._ID;
            p.PostalCode = g._PostalCode;
            p.State = g._State;
            p.Name = g._UnparsedName;

            if (!string.IsNullOrEmpty(g.NonPersonEntityIndicator) && g.NonPersonEntityIndicator.ToUpper() == "Y")
                p.nonPersonEntity = true;
            
            return p;
        }

        /// <summary>
        /// Creates a FilingParty from a strongly typed Pria Respond to Party
        /// </summary>
        /// <returns>A FilingParty Object</returns>
        internal static FilingParty FromPriaRespondToParty(PRIALibraryV24.PRIA_RESPOND_TO_PARTY_Type g)
        {
            FilingParty p = new FilingParty();
            p.Address1 = g._StreetAddress;
            p.Address2 = g._StreetAddress2;
            p.City = g._City;
            p.PostalCode = g._PostalCode;
            p.State = g._State;
            p.Name = g._Name ;
            

            return p;
        }
    }
}
