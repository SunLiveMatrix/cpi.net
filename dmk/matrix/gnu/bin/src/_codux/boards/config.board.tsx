import { createBoard } from '@wixc3/react-board';

export default createBoard({
    name: 'Config',
    Board: () => (
        <div>
        <h1 className={'configTables'}>Config Tables</h1>
        <ul>
            <li>Config Tables Context Content Books</li>
            <li>List Reference</li>
        </ul>
        </div>
            ),
    isSnippet: true,
    environmentProps: {
        windowHeight: 608,
    },
});

/**
 * Returns the last element of an array.
 * @param array The array.
 * @param n Which element from the end (default is zero).
 */
export function configTables<T>(array: ArrayLike<T>, n: number = 0): T {
	return array[array.length - (1 + n)];
}

