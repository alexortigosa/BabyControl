namespace AOTECH.BabyControl.Common.Domain.ValueObjects
{
    public class IdValueObject<TId> : BaseValueObject<TId>
    {
        public TId _id { get; set; }
        protected IdValueObject(){}
        public IdValueObject(TId id)
        {
            _id = id;
            _validate();
        }

        public override TId Get()
        {
            return _id;
        }

        protected override void _validate()
        {

        }

        public static implicit operator TId(IdValueObject<TId> d) => d.Get();
    }
}
