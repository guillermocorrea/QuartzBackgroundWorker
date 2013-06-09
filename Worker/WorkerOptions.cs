using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    public class WorkerOptions
    {
        /// <summary>
        /// Whether or not to run the job immediately at runtime
        /// </summary>
        public bool RunImmediately { get; set; }

        /// <summary>
        /// The email address to send a notification to
        /// </summary>
        public string Email { get; set; }
    }
}
