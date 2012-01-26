using Argon.Network.Profile;

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

            newProfile.Id=Controller.Instance.CreateNewProfileId();
            newProfile.Name = "Copy of " + newProfile.Name;

            _controller.Model.AddProfile(newProfile);            
        }
    }
}