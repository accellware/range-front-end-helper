namespace Your.Namespace
{
    class Range<T>
        where T: struct
    {
        private dynamic _min;
        private dynamic _max;

        public T Min { get => (T)_min; }

        public T Max { get => (T)_max; }

        public Range(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public Range(long min, long max)
        {
            _min = min;
            _max = max;
        }

        public Range(double min, double max)
        {
            _min = min;
            _max = max;
        }

        public Range(float min, float max)
        {
            _min = min;
            _max = max;
        }
    }
}
