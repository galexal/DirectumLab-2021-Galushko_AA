import * as React from 'react';
import download from '../../images/download_24px.svg';
import basket from '../../images/delete_24px.svg';
import './story.css';
import '../sidebar/sidebar.css';
import { Path } from '../../routes';

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
            <tr key={story.storyName}><td><a href={`${Path.planning}/modal`} id="ModalWindowClose">{story.storyName}</a></td><td>{story.avg}</td><td ><button className="basket" ><img src={basket} alt="Иконка корзины"/></button></td></tr>    
        )}
      </table>
    </div>
  );
};

export default Story;
