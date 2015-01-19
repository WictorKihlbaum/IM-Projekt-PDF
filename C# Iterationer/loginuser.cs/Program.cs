using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginuser.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests.CompareUserInput();
            Tests.CheckUsernameFormat();
            Tests.CheckPasswordFormat();

            Integrationtest.CompareUserInput();

            ApplicationTesting.ValidateUserAccess();
            ApplicationTesting.ValidateTeamname();
            ApplicationTesting.ValidateAmountOfGymnasts();
            ApplicationTesting.ValidateGymnastName();
            ApplicationTesting.ValidateGymnastAge();
            ApplicationTesting.ValidateGymnastGender();
            ApplicationTesting.ValidateForm();

            FormTesting.ValidateUserAccess();
            FormTesting.ValidateGivenPoint();
            FormTesting.ValidateAveragePointFields();
            FormTesting.ValidateTeamPointFields();
            FormTesting.ValidateStoredFiles();

            StoredFilesTesting.ValidateUserAccess();
            StoredFilesTesting.ValidatePublishableFiles();
        }
    }
}
