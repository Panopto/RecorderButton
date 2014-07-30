/// <summary>
/// Sample C# that uses the Panopto PublicAPI
/// This sample shows how to start and stop a new session recording.
/// </summary>
namespace RecordingManagementExample
{
    using RecordingManagementExample.RecorderManagement;
    using System;
    using System.Collections.Generic;
    using System.Threading;

    /// <summary>
    /// Starts and stops a recording session in a Panoto server.
    /// </summary>
    internal class Program
    {
        // Sets Panopto user authentication details
        static string userKey = "user";
        static string password = "password";

        // Sets Panopto session name
        static string newSessionName = "PanoptoNewSession";

        // The Id of the remote recorder that will record the new session
        static Guid remoteRecorderId = Guid.Parse("5dc0864b-df08-4620-9f85-000000000");

        // The id of the Panopto server foldr where the new session will be saved.
        static Guid panoptoFolderId = Guid.Parse("3e127927-839a-4f0b-a461-000000000");

        private static void Main(string[] args)
        {
            // Creates a Recorder Management Client
            RecorderManagement.RemoteRecorderManagementClient recorder = new RemoteRecorderManagementClient();

            // Permissions required to work with Panopto API interfaces
            RecorderManagement.AuthenticationInfo authInfo = new RecorderManagement.AuthenticationInfo()
            {
                UserKey = userKey,
                Password = password
            };

            Console.WriteLine("Starting a new recording for recorder with ID: " + remoteRecorderId);
            Console.WriteLine("Recording in folder with ID: " + panoptoFolderId);

            // The new session recording will start when this line is executed.
            RecorderManagement.ScheduledRecordingResult result = StartRecordingSession(recorder, authInfo, 60, newSessionName, panoptoFolderId , remoteRecorderId);

            // Only try to stop the session if we successfully started it.
            if (result != null
                && result.SessionIDs != null)
            {
                // The execution will wait some time just for test aim.
                Thread.Sleep(5000);

                // The session recording will be stoped when this line is executed. 
                RecorderManagement.ScheduledRecordingResult stopResult = StopSessionRecording(recorder, authInfo, result.SessionIDs[0]);
            }
            else
            {
                Console.WriteLine("Unable to start the recording.");
            }

            Console.WriteLine("Recording complete. Press enter to return.");
            Console.ReadLine();
        }

        /// <summary>
        /// Stars a new recording session.
        /// </summary>
        /// <param name="recorder">Recorder Client to schedule the new session.</param>
        /// <param name="authInfo">Panopto user Authenticaion info.</param>
        /// <param name="sessionLength">The session duration in minutes.</param>
        /// <param name="sessionName">The new session name.</param>
        /// <param name="folderId">The id os the folder where the new session will be located.</param>
        /// <param name="recorderId">The id of the remote recorder that will be used to record the new session.</param>
        /// <returns>Returns the schedule result.</returns>
        private static RecorderManagement.ScheduledRecordingResult StartRecordingSession(RecorderManagement.RemoteRecorderManagementClient recorder, RecorderManagement.AuthenticationInfo authInfo, int sessionLength, string sessionName, Guid folderId, Guid recorderId)
        {
            // Creates the recording settings list
            List<RecorderManagement.RecorderSettings> recorderSettings = new List<RecorderSettings>();
            RecorderManagement.ScheduledRecordingResult sr = new ScheduledRecordingResult();
            try
            {
                Console.WriteLine("Starting recording.");

                // Sets the remote recording id in the recording settings
                recorderSettings.Add(new RecorderSettings { RecorderId = recorderId });

                // Schedules a new recording session that will start at the current time.
                sr = recorder.ScheduleRecording(authInfo, sessionName, folderId, false, DateTime.Now, DateTime.Now.AddMinutes(sessionLength), recorderSettings.ToArray());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return sr;
        }

        /// <summary>
        /// Stops the recording of a session that is currently recording.
        /// </summary>
        /// <param name="recorder">Recorder Client that is executing the session.</param>
        /// <param name="authInfo">Panopto user Authenticaion info.</param>
        /// <param name="sessionId">The session to be stoped.</param>
        /// <returns>Returns the schedule result.</returns>
        private static RecorderManagement.ScheduledRecordingResult StopSessionRecording(RecorderManagement.RemoteRecorderManagementClient recorder, RecorderManagement.AuthenticationInfo authInfo, Guid sessionId)
        {
            Console.WriteLine("Stopping recording.");
            // Updates the recording setting the current time as the finish time. That will stop the current session recording.
            return recorder.UpdateRecordingTime(authInfo, sessionId, DateTime.Now, DateTime.Now);
        }
    }
}