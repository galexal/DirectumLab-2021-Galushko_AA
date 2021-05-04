import { IRootState } from './types';
import { Action } from 'redux';

const initState: IRootState = {
    rooms: [
        {
            id: '777',
            name: 'First Room',
            cards: ['0', '0.5', '1', '2', '3', '5', '8', '13', '20', '40', '100', '?', '☕'],
            selectedCard: null,
            ownerId: 'test_user',
        },
    ],
    stories: [
        {
            id: '1',
            name: 'The first story',
            average: 8,
            votes: {
                player_1: '8',
                player_2: '8',
            },
        },
        {
            id: '2',
            name: 'The second story',
            average: 16,
            votes: {
                player_1: '16',
                player_2: '16',
            },
        },
    ],
    user: {
        id: 'test_user',
        name: 'Tester',
    },
}

export const ActionType = {
    VOTE: 'VOTE',
    REMOVE_STORY: 'REMOVE_STORY',
}

interface IVoteAction extends Action {
    roomId: string,
    selectedCard: string,
}

export const vote = (roomId: string, value: string): IVoteAction => {
    return {
        type: ActionType.VOTE,
        roomId: roomId,
        selectedCard: value,
    }
};

interface IRemoveStoryAction extends Action {
    id: string,
}

export const removeStory = (id: string): IRemoveStoryAction => {
    return {
        type: ActionType.REMOVE_STORY,
        id: id,
    }
}

export const reducer = (state: IRootState = initState, action: Action): IRootState => {
    switch (action.type) {
        case ActionType.VOTE: {
            const voteAction = action as IVoteAction;
            return {
                ...state,
                rooms: state.rooms.map(r => {
                    if (voteAction.roomId === r.id) {
                        return {
                            ...r,
                            selectedCard: voteAction.selectedCard
                        }
                    }
                    return r;
                })
            }
        }
        case ActionType.REMOVE_STORY: {
            const removeAction = action as IRemoveStoryAction;
            return {
                ...state,
                stories: state.stories.filter(s => s.id !== removeAction.id)
            }
        }
        default:
            return state;
    }
}
