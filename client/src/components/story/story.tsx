import * as React from 'react';
import download from '../../images/download_24px.svg';
import basket from '../../images/delete_24px.svg';
import userIcon from '../../images/User_Icon.svg';
import './story.css';
import '../sidebar/sidebar.css';

interface IProps {
  stories: Array <{storyName: string, avg: number, users: Array<{userName: string, vote: number}>}>
}

const Story: React.FC<IProps> = ({
  stories
}) => {
  return (
    <div className="story">
      <div className="story-title">
        <p className="completed_stories">Completed Stories</p>
        <p className="stories-number">{stories.length}</p>
        <a className="download" href=""><img src={download} alt="Иконка скачивания"/></a>
      </div>
      <table className="table">
        {stories.map((story)=>
            <tr key={story.storyName}><td><a href="#ModalWindow" id="ModalWindowClose">{story.storyName}</a></td><td>{story.avg}</td><td ><button className="basket" ><img src={basket} alt="Иконка корзины"/></button></td></tr>    
        )}
      </table>
      <div id="ModalWindow" className="modal">
    <div className="modal_body">
        <div className="modal-window">
          <p className="sidebar__header">Story Details</p>
          <h3 className="players">Players:</h3>
          {stories.map((story)=>
            story.users.map((user) => 
                <div key={user.userName} className="user-in-sidebar">
                    <img src={userIcon} width="48" height="48" alt="Аватарка пользователя"/>
                    <p className="user-in-story">{user.userName}</p>
                    <p className="vote-in-modal">{user.vote}</p>
                </div>
        ))}
          <button ><a className="button-in-modal" href="#ModalWindowClose">Close</a></button>
        </div>
    </div>
  </div>
    </div>
  );
};

export default Story;
