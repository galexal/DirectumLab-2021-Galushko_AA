import * as React from 'react';
import userIcon from '../../images/User_Icon.svg';
import './sidebar.css';

interface Props {
    needHideVote?: boolean;
    users: Array<string>;
    // users: Array<{name: string, vote?: string}>;
}

const Sidebar: React.FC<Props> = ({
  needHideVote,
  users
}) => {
  return (
    <div className="sidebar">
      <p className="sidebar__header">Story voting completed</p>
      <h3 className="players">Players:</h3>
      {users.map((user)=>
        <div key={user} className="user-in-sidebar">
          <img src={userIcon} width="48" height="48" alt="Аватарка пользователя"/>
          <p className="user-in-story">{user}</p>
          {needHideVote // user.vote && needHideVote 
            ? <svg className="check" width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                <path fillRule="evenodd" clipRule="evenodd" d="M0 10C0 4.48 4.48 0 10 0C15.52 0 20 4.48 20 10C20 15.52 15.52 20 10 20C4.48 20 0 15.52 0 10ZM3 10L8 15L17 6L15.59 4.58L8 12.17L4.41 8.59L3 10Z" fill="#4B9AE8" fillOpacity="0.54"/>
            </svg>
            : <div className="check">{user}</div> // user.vote
          }
        </div>
      )}
      <button className="finish_button">Finish Voting</button>
      <div className="invite">
        <h3 className="invite_header">Invite a teammate</h3>
        <input className="invite_input" type="text" name="inviteLink" id="inviteLink" placeholder="https://www.planitpoker.com/board" readOnly/>
      </div>
    </div>
  );
};

export default Sidebar;
