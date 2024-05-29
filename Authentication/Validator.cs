using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace Authentication
{
    public class Validator
    {
        private List<string> _validationStrings = new List<string>();

        public static char[] blackListChars = new char[] { '\'', '*', ';' };

        public Validator(List<string> validationStrings)
        {
            _validationStrings = validationStrings;
        }

        public bool Validate(List<Func<bool>> validationFunctions)
        {
            bool flag = false;
            foreach (Func<bool> function in validationFunctions) 
            {
                flag = function.Invoke();
            }
            return flag;
        }

        public bool HasNoBlackListChar()
        {
            var flag = false;
            _validationStrings.ForEach( x => {
                flag = !x.All<char>( c => blackListChars.Contains( c ) );
            } );
            return flag;
            
        }

        public bool HasNoWhiteSpace()
        {
            var flag = false;
            _validationStrings.ForEach( x => {
                flag = !x.All<char>( c => c == ' ' );
            } );
            return flag;
        }

        public bool IsNotEmpty()
        {
            var flag = false;
            _validationStrings.ForEach( x => {
                flag = !( x.Length == 0 );
            } );
            return flag;
        }
    }
}