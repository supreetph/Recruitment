using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitementTracker.Models
{
    public class Candidate
    {
      
            [JsonProperty("OpportunityID")]
            public int OpportunityID;

            [JsonProperty("RequirementId")]
            public string RequirementId;

            [JsonProperty("CandidateName")]
            public string CandidateName;

            [JsonProperty("Skills")]
            public string Skills;

            [JsonProperty("Experience")]
            public string Experience;

            [JsonProperty("ProfilesharedwithPanel")]
            public string ProfilesharedwithPanel;

            [JsonProperty("DateShared")]
            public string DateShared;

            [JsonProperty("Status")]
            public List<string> Status;

            [JsonProperty("ProfileSource")]
            public string ProfileSource;

            [JsonProperty("Internal/External")]
            public string InternalExternal;

            [JsonProperty("Stage")]
            public List<string> Stage;
        }

    
}
