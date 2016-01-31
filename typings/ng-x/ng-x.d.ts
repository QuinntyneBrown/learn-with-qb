declare var ngX: IngX; 

declare interface IngX {
    Component: any,
    Store:any
}

declare interface IStore {
    storeInstance: any;
    items: any[],
    registerListeners(): void;
}