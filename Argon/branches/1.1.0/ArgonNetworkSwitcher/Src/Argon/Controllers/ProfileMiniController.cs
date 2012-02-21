using Argon.Windows.Network.Profile;
using Argon.Models;
using Argon.UseCase;

namespace Argon.Controllers
{

    public class ProfileMiniController : MiniController
    {
        public ProfileMiniController(Controller controller)
            : base(controller)
        {
        }

        public void DuplicateProfile(NetworkProfile profile)
        {
            NetworkProfile newProfile = new NetworkProfile();
            newProfile=NetworkProfile.Copy(profile);

            newProfile.Id=UseCaseProfile.CreateNewProfileId();
            newProfile.Name = "Copy of " + newProfile.Name;

            DataModel.NetworkProfileList.Add(newProfile);
        }
    }
}