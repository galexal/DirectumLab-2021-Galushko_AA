import * as React from 'react';
import userIcon from '../../images/User_Icon.svg';
import '../story/story.css';
import '../sidebar/sidebar.css';

interface IProps {
  users: Array<{userName: string, vote: string|null}>|undefined,
  onModalOpenClose(storyId?: string): void;
}

const Modal: React.FC<IProps> = ({
  users,
  onModalOpenClose
}) => {
  const handleClick = () => onModalOpenClose();
  return (
    <div className="story">
      <div id="ModalWindow" className="modal">
        <div className="modal_body">
          <div className="modal-window">
              <p className="sidebar__header">Story Details</p>
              <h3 className="players">Players:</h3>
              {users&&users.map((user) => 
                  <div key={user.userName} className="user-in-sidebar">
                      <img src={userIcon} width="48" height="48" alt="Аватарка пользователя"/>
                      <p className="user-in-story">{user.userName}</p>
                      <p className="vote-in-modal">{user.vote}</p>
                  </div>
                  )}
              <button className="button-in-modal" onClick={handleClick}>Close</button>
          </div>
        </div>
        </div>
     </div>
  );
};

export default Modal;
