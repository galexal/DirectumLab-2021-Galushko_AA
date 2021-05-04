export interface IUser {
    id: string;
    name: string;
}

export interface IRoom {
    id: string;
    name: string;
    cards: Array<string>;
    selectedCard: string | null;
    ownerId: string; // id user
}

export interface IStory {
    id: string;
    name: string;
    average: number | null;
    votes: { [key: string]: string}; // key - userId, value - vote
}

export interface IRootState {
    rooms: Array<IRoom>;
    stories: Array<IStory>;
    user: IUser | null;
}