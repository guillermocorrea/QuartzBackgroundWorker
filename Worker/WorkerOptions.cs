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

        /// <summary>
        /// Our email username
        /// </summary>
        public string EmailUsername { get; set; }

        /// <summary>
        /// Our email password
        /// </summary>
        public string EmailPassword { get; set; }

        /// <summary>
        /// Our email server
        /// </summary>
        public string EmailServer { get; set; }

        /// <summary>
        /// Our email port
        /// </summary>
        public int EmailPort { get; set; }
    }
}
