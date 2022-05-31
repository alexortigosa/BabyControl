using AOTECH.BabyControl.Common.Domain.ValueObjects;

namespace AOTECH.BabyControl.Common.Domain.Entities
{
    public abstract class BaseEntity<TId>
    {
        public IdValueObject<TId> _idValueObject { get; set; }

        protected BaseEntity()
        {
        }

        protected BaseEntity(IdValueObject<TId> idValueObject)
        {
            _idValueObject = idValueObject;
        }

        public IdValueObject<TId> GetId()
        {
            return _idValueObject;
        }

        public void SetId(IdValueObject<TId> id)
        {
            _idValueObject = id;
        }
    }
}
