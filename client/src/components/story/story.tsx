import * as React from 'react';
import download from '../../images/download_24px.svg';
import basket from '../../images/delete_24px.svg';
import './story.css';
import '../sidebar/sidebar.css';
import { Path } from '../../routes';
import { Link } from 'react-router-dom';

interface IProps {
  stories: Array <{storyName: string, avg: number, users: Array<{userName: string, vote: number}>}>;
  onModalClick: any;
}

const Story: React.FC<IProps> = ({
  stories,
  onModalClick
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
            <tr key={story.storyName}><td><Link onClick={onModalClick} to={`${Path.PLANNING}`} id="ModalWindowClose">{story.storyName}</Link></td><td>{story.avg}</td><td ><button className="basket" ><img src={basket} alt="Иконка корзины"/></button></td></tr>    
        )}
      </table>
    </div>
  );
};

export default Story;
