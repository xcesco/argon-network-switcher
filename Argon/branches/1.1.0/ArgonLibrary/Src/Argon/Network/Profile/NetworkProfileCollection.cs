using System;
using System.Collections.Generic;
using System.Text;

namespace Argon.Network.Profile
{
    public class NetworkProfileCollection : ICollection<NetworkProfile>
    {
        List<NetworkProfile> list;

        public NetworkProfileCollection()
        {
            list = new List<NetworkProfile>();
        }

        public NetworkProfile this[int key]
        {
            get {
                foreach (NetworkProfile item in list)
                {
                    int temp = item.Id;
                    if (temp.Equals(key))
                    {
                        return item;
                    }
                }

                return null;
            }             
        }

        public bool Add(NetworkProfile profile)
        {
            NetworkProfile app = this[profile.Id];

            if (app == null)
            {
                list.Add(profile);
                return true;
            }
            else
            {
                int key = profile.Id;
                int temp;
                for (int i = 0; i < list.Count; i++)
                {
                    temp = list[i].Id;
                    if (temp.Equals(key))
                    {
                        list[i] = profile;
                    }
                }
                return false;
            }
        }

        public int Count
        {
            get { return list.Count; }
        }


        #region ICollection<NetworkProfile> Members

        void ICollection<NetworkProfile>.Add(NetworkProfile item)
        {
            //Add(item);
            throw new Exception("The method or operation is not implemented.");
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(NetworkProfile item)
        {
            return this[item.Id]==null ? false: true;
        }

        public void CopyTo(NetworkProfile[] array, int arrayIndex)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool Remove(NetworkProfile item)
        {
            NetworkProfile temp = this[item.Id];

            if (temp != null)
            {
                return list.Remove(temp);
            }
            return false;
        }

        #endregion

        #region IEnumerable<NetworkProfile> Members

        public IEnumerator<NetworkProfile> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        #endregion
    }
}
