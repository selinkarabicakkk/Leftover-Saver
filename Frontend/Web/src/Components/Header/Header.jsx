import React from 'react';
import Logo from '../../Assets/images/AppLogo.jpg';
import { Link } from 'react-router-dom';


import './Header.css'; 

const Header = () => {
    return (
            <div className="header">
                <Link className='logo' to="/"><img src={Logo} alt="Logo" /></Link>
                
                <div className='exceptLogo'>

                    <div className='leftdiv'>
                        <Link className='consumer' to="/consumer"><span>Consumer</span></Link>
                        <Link className='business' to="/business"><span>Business</span></Link>
                    </div>

                    <div className='rightdiv'>
                        <Link to="/sign-in"><button>Sign In</button></Link>
                        <Link to="/sign-up"><button>Sign Up</button></Link>
                    </div>

                </div>
            </div>
    );
};
export default Header; 