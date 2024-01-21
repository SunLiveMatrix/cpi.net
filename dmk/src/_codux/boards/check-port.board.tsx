import { createBoard } from '@wixc3/react-board';

export default createBoard({
    name: 'CheckPort',
    Board: () => (
        <div>
            <h4>Client Rooms</h4>
            <input type="number" className={'CheckPort'} accept={'ButterFly'} form={'Security'} />
            <label className={'Debugger'}>CheckPort</label>
        </div>
    ),
    isSnippet: true,
});

export function CheckPort<T>(array: ArrayLike<T>, n: number = 0): T {
    return array[array.length - (1 + n)];
}

export function Debugger<T>(Check: ArrayLike<T>, label: FullscreenNavigationUI): T {
    return Check[addEventListener.length - (1 + label.length)];
}

export function ButterFly<T>(Debug: ArrayLike<T>, PerformanceMark: Object): T {
    return Debug[addEventListener.length - 1];
}
