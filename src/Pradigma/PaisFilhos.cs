using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Pradigma
{
    public class Entity
    {
        public string Name { get; set; }
        public List<Entity> Child { get; set; }

        public Entity(string name)
        {
            this.Name = name;
            this.Child = new List<Entity>();
        }
    }

    public static class ThereIsEntity
    {
        public static bool ThereIs(this Entity entity, string name)
        {
            var result = entity.GetPlace(name);

            return result != null;
        }

        public static Entity GetPlace(this Entity entity, string name)
        {
            if (entity.Name.ToLower().Equals(name.ToLower()))
            {
                return entity;
            }

            Entity result = null;

            foreach (var child in entity.Child)
            {
                result = child.GetPlace(name);

                if (result != null)
                {
                    break;
                }
            }

            return result;
        }
    }

    #region Exceptions

    internal class ThereIsException : Exception
    {
        public ThereIsException() : base("E2: Some item found in tree.")
        {
        }
    }

    internal class PlaceNotFoundException : Exception
    {
        public PlaceNotFoundException(string name) : base($"E4: The Entity with name '{name}' was not found.")
        {
        }
    }

    internal class ChildRangeException : Exception
    {
        public ChildRangeException(string entityName) : base($"The Entity '{entityName}' has two child.")
        {
        }
    }

    internal class RootWasFoundException : Exception
    {
        public RootWasFoundException(string name) : base($"E3: There is a root place with name '{name}'.")
        {
        }
    }

    #endregion

    internal class Solution
    {
        private Entity _entity;

        public Solution(string name)
        {
            this._entity = new Entity(name);
        }

        public void AddItem(string name, string place)
        {
            if (this._entity.Name.ToLower().Equals(name.ToLower()))
            {
                throw new RootWasFoundException(name);
            }

            if (this._entity.ThereIs(name))
            {
                throw new ThereIsException();
            }

            var entityPlace = this._entity.GetPlace(place) ?? throw new PlaceNotFoundException(place);

            if (entityPlace.Child.Count() == 2)
            { 
                throw new ChildRangeException(entityPlace.Name);
            }

            entityPlace.Child.Add(new Entity(name));
        }
    }

    
}
