#include <stdlib.h>

template <typename T> class List
{
private:
    T* data = NULL;
    int dataSize = 0;
    int count = 0;

    void GrowList( int newSize )
    {
        dataSize = newSize;
        data = (T*)realloc( data, dataSize * sizeof( T ) );
    }

    void CheckSize()
    {
        if( dataSize == count )
        {
            GrowList( dataSize * 2 );
        }
    }

public:
    List( int initialCount=10 )
    {
        if( initialCount <= 0 )
        {
            initialCount = 10;
        }
        GrowList( initialCount );
    }

    ~List()
    {
        free( data );
        data = NULL;
    }

    int Count()
    {
        return count;
    }

    T operator []( int i ) const
    {
        return data[ i ];
    }

    T& operator []( int i )
    {
        return data[ i ];
    }

    void Add( T item )
    {
        CheckSize();

        data[ count ] = item;
        count++;
    }

    void Insert( int index, T item )
    {
        if( index >= count )
        {
            return;
        }

        CheckSize();

        memmove( &data[ index + 1 ], &data[ index ], ( count - index ) * sizeof( T ) );
        data[ index ] = item;
        count++;
    }

    void Clear()
    {
        memset( data, 0, dataSize * sizeof( T ) );
        count = 0;
    }
};
