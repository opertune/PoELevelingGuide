using System;

namespace PoELevelingGuide
{
    [Serializable]
    public class Profile
    {
        private string name;
        private int quete;
        private int act;
        private string gems;
        private string talents;
        public Profile(string name, int quete, int act, string gems, string talents)
        {
            this.name = name;
            this.quete = quete;
            this.act = act;
            this.gems = gems;
            this.talents = talents;
        }
        public string getName()
        {
            return this.name;
        }
        public int getQuete()
        {
            return this.quete;
        }
        public int getAct()
        {
            return this.act;

        }
        public string getGems()
        {
            return this.gems;
        }
        public string getTalents()
        {
            return this.talents;
        }

        public void setAct(int nb)
        {
            this.act = nb;
        }
        public void setQuete(int nb)
        {
            this.quete = nb;
        }
        public void setGems(string gem)
        {
            this.gems = gem;
        }
        public void setTalents(string talent)
        {
            this.talents = talent;
        }
        public object infosProfile()
        {
            return getName() + ":" + getAct() + ":" + getQuete();
        }
    }
}
