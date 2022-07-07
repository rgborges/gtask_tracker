using System;
using System.Collections.Generic;
using gtask_tracker.console.lib;
using gtask_tracker.console.models;

namespace gtask_tracker.console.app.debug
{
    public class Debug
    {
        private DateTime startTime;
        public ReportDTO GetSampleData()
        {
            var records = new List<TaskLogRecordDTO>();
            records.Add(new TaskLogRecordDTO {
                Id = 1,
                CommitMessage = "Start to reading and trying to discover the issue", 
                DevelopmentDetails = @"
                    We had analysed a bunch of thiings asjdfpasjdfj asfa
                    sfasdjfp asjdfaksf
                    asdf aosdjf[pajsdfkasdfias
                    d=pf
                    as=dfpi=asdfsajdfjasdfajsdfasjdfásjda
                    dfasjfpasjdfpjaspfjaspdjfa
                    fsdafjpasjdfpasjdfas]
                ",
                Timestamp = DateTime.Now
                }
            );
            records.Add(new TaskLogRecordDTO {
                Id = 2,
                CommitMessage = "We found where the issue is ", 
                DevelopmentDetails = @"
                    Wdsfsçldfmas lakmflakdfaskdfáksdfka
                    sfasdfpáskfpaskfka
                    sfk
                    asdfk
                    as[dpfk[asdfksakfldkslkfldkfasf
                    asddfpasdfldsa
                    fsdafjpasjdfpasjdfas]
                ",
                Timestamp = DateTime.Now
                }
            );

            var tasks = new List<TaskLogDTO>() {

            }
            

            var report = new ReportDTO {
                Id = 1,
                Tasks = 
            }
        }
    }
}