import * as React from 'react';
import userIcon from '../../images/User_Icon.svg';
import {history} from '../../index'
import { Path } from '../../routes';
import './sidebar.css';

interface IProps {
    needHideVote?: boolean;
    users: Array<{userName: string, vote?: string}>;
    votingIsFinish?: boolean;

}

const Sidebar: React.FC<IProps> = ({
  needHideVote,
  users,
  votingIsFinish
}) => {
  const handleClickFinishVoting = () => {
    const roomId = 42;
    history.push(`${Path.planning}/${roomId}/result`)
  }
  const handleClickNewStory = () => {
    const roomId = 42;
    history.push(`${Path.planning}/${roomId}`)
  }
  return (
    <div className="sidebar">
      <p className="sidebar__header">Story voting completed</p>
      <h3 className="players">Players:</h3>
      {users.map((user)=>
        <div key={user.userName} className="user-in-sidebar">
          <img src={userIcon} width="48" height="48" alt="Аватарка пользователя"/>
          <p className="user-in-story">{user.userName}</p>
          {user.vote && needHideVote 
            ? <svg className="check" width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                <path fillRule="evenodd" clipRule="evenodd" d="M0 10C0 4.48 4.48 0 10 0C15.52 0 20 4.48 20 10C20 15.52 15.52 20 10 20C4.48 20 0 15.52 0 10ZM3 10L8 15L17 6L15.59 4.58L8 12.17L4.41 8.59L3 10Z" fill="#4B9AE8" fillOpacity="0.54"/>
            </svg>
            : <div className="check">{user.vote}</div>
          }
        </div>
      )}
      {votingIsFinish
        ? <div className="new-story">
            <input className="new-story_input" type="text" name="discussionname" id="discussionname" placeholder="Enter new discussion name" required/>
            <button className="new-story_button" onClick={handleClickNewStory}>Go</button>
          </div>
        : <button className="finish_button" onClick={handleClickFinishVoting}>Finish Voting</button>  
      }
      <div className="invite">
        <h3 className="invite_header">Invite a teammate</h3>
        <input className="invite_input" type="text" name="inviteLink" id="inviteLink" placeholder="https://www.planitpoker.com/board" readOnly/>
      </div>
    </div>
  );
};

export default Sidebar;
