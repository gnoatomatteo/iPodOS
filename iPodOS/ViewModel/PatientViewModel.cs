using iPodOS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPodOS.ViewModel
{
    internal class PatientViewModel
    {
        private IList<Patient> _patientList;

        public PatientViewModel()
        {
#if DEBUG
            _patientList = new List<Patient>
            {
                new Patient
                {
                    Guid = Guid.NewGuid().ToString("N"),
                    DateOfBirth = DateTime.Now,
                    Name = "Arturo",
                    Surname = "Surname",
                    MedicalExaminations = new List<MedicalExamination>
                    {
                        new MedicalExamination
                        {
                            Data = DateTime.Now,
                            FreeText = "venuto a fare visita piede destro perché quando camminava bestemmiava dal dolore acuto"
                        }
                    }
                }
            };
#endif
        }
    }
}
