using System.Collections.Generic;

namespace NINumberValidator
{
    public class NIValidator
    {
        public bool IsValid(string niNumber)
        {
            bool isValid = false;
            if(!string.IsNullOrEmpty(niNumber))
            {
                if (niNumber.Length == 9)
                {
                    string firstChar = niNumber.Substring(0,1);
                    string secondChar = niNumber.Substring(1, 1);
                    int dummyVal = 0;
                    bool firstTwoAreNotNumeric = !int.TryParse(firstChar, out dummyVal) && !int.TryParse(secondChar, out dummyVal);
                    bool next6AreNumeric = int.TryParse(niNumber.Substring(2,6), out dummyVal);
                    bool finalCharacterIsValid = "ABCD".IndexOf(niNumber.Substring(8,1)) > -1;
                    bool firstCharacterIsValid = !("DFIQUV".IndexOf(firstChar) > -1);
                    bool secondCharacterIsValid = !("DFIOQUV".IndexOf(secondChar) > -1);
                    List<string> firstTwoInvalidGroups = new List<string> { "GB", "BG", "NK", "KN", "NT", "TN", "ZZ" };
                    bool firstTwoAreValid = !firstTwoInvalidGroups.Contains(niNumber.Substring(0, 2));

                    isValid = 
                        firstTwoAreNotNumeric && 
                        next6AreNumeric && 
                        finalCharacterIsValid && 
                        firstCharacterIsValid && 
                        secondCharacterIsValid &&
                        firstTwoAreValid;
                }
            }
            return isValid;
        }
    }
}
