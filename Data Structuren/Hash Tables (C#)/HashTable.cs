using System;
namespace HashTable {
    public class HashEntry<T, U> {
        private T Key;
        private U Value;

        public HashEntry( T key, U value ) {
            this.Key = key;
            this.Value = value;
        }

        public T getKey() {
            return this.Key;
        }

        public U getValue() {
            return this.Value;
        }
    }

    public class HashTable<T, U> {
        HashEntry<T, U>[] Buckets;
        int Size;

        public HashTable( int size ) {
            this.Size = size;
            this.Buckets = new HashEntry<T, U>[ size ];
            for ( int index = 0; index < this.Buckets.Length; index = index + 1 ) {
                this.Buckets[index] = null;
            }
        }

        private int CreateHashIndex( T key ) {
            int hash = Math.Abs( key.GetHashCode() );
            return hash % this.Size;
        }

        private bool HasOpenSpaces() {
            for ( int index = 0; index < this.Buckets.Length; index = index + 1 ) {
                if ( this.Buckets[index] == null ) {
                    return true;
                }
            }

            return false;
        }

        public U Get( T key ) {
            int index = this.CreateHashIndex( key );
            while ( this.Buckets[index] != null && !this.Buckets[index].getKey().Equals( key ) ) {
                index = ( index + 1 ) % this.Size;
            }

            if ( this.Buckets[index] == null ) {
                return default( U );
            }

            else {
                return this.Buckets[index].getValue();
            }
        }

        public bool Insert( T key, U value ) {
            if ( this.HasOpenSpaces() ) {
                int index = this.CreateHashIndex( key );

                while ( this.Buckets[index] != null && !this.Buckets[index].getKey().Equals( key ) ) {
                    if ( this.Buckets[index].getKey().Equals( key ) ) {
                        throw new ArgumentException( "Key already exists" );
                    }

                    index = ( index + 1 ) % this.Size; 
                }

                this.Buckets[index] = new HashEntry<T, U>( key, value );
            }

            return false;
        }

        public bool Remove( T key ) {
            int index = this.CreateHashIndex( key );
            while ( this.Buckets[index] != null && !this.Buckets[index].getKey().Equals( key ) ) {
                index = ( index + 1 ) % this.Size;
            }

            if ( this.Buckets[index] == null ) {
                return false;
            }

            else {
                this.Buckets[index] = null;
                return true;
            }
        }

        public void print() {
            for ( int index = 0; index < this.Buckets.Length; index = index + 1 ) {
                if ( this.Buckets[index] == null ) {
                    continue;
                }

                HashEntry<T, U> entry = this.Buckets[index];
                Console.WriteLine( "{0} -> {1}", entry.getKey(), entry.getValue());
            }
        }
    }
}
