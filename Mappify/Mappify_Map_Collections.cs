﻿namespace Mappify
{
    public partial class Mappify
    {
        public virtual List<TD> MapList<TD>(IEnumerable<object> sources)
        {
            if (sources == null)
            {
                return default;
            }

            var result = new List<TD>();

            foreach (var source in sources)
            {
                var mapped = Map<TD>(source);

                if (mapped != null)
                {
                    result.Add(mapped);
                }
            }

            return result;
        }

        public virtual List<TD> MapList<TD>(object[] sources)
        {
            if (sources == null)
            {
                return default;
            }

            var result = new List<TD>();

            foreach (var source in sources)
            {
                var mapped = Map<TD>(source);

                if (mapped != null)
                {
                    result.Add(mapped);
                }
            }

            return result;
        }

        public virtual TD[] MapArray<TD>(object[] sources)
        {
            if (sources == null)
            {
                return default;
            }

            //todo: Оптимизировать.
            var result = new List<TD>();

            foreach (var source in sources)
            {
                var mapped = Map<TD>(source);

                if (mapped != null)
                {
                    result.Add(mapped);
                }
            }

            return result.ToArray();
        }

        public virtual TD[] MapArray<TD>(IEnumerable<object> sources)
        {
            if (sources == null)
            {
                return default;
            }

            //todo: Оптимизировать.
            var result = new List<TD>();

            foreach (var source in sources)
            {
                var mapped = Map<TD>(source);

                if (mapped != null)
                {
                    result.Add(mapped);
                }
            }

            return result.ToArray();
        }

        public virtual Queue<TD> MapQueue<TS1, TD>(Queue<TS1> sources)
        {
            if (sources == null)
            {
                return default;
            }

            var result = new Queue<TD>();

            foreach (var source in sources)
            {
                var mapped = Map<TS1, TD>(source);

                if (mapped != null)
                {
                    result.Enqueue(mapped);
                }
            }

            return result;
        }

        public virtual Stack<TD> MapStack<TS1, TD>(Stack<TS1> sources)
        {
            if (sources == null)
            {
                return default;
            }

            var result = new Stack<TD>();

            foreach (var source in sources)
            {
                var mapped = Map<TS1, TD>(source);

                if (mapped != null)
                {
                    result.Append(mapped);
                }
            }

            return result;
        }

        public virtual IDictionary<TDk, TD> MapDictionary<TS1, TD, TDk>(IDictionary<TDk, TS1> sources)
        {
            if (sources == null)
            {
                return default;
            }

            var result = new Dictionary<TDk, TD>();

            foreach (var source in sources)
            {
                var mapped = Map<TS1, TD>(source.Value);

                if (mapped != null)
                {
                    result.Add(source.Key, mapped);
                }
            }

            return result;
        }
    }
}