'use client'
import Link from "next/link";
import styles from "./header.module.css"
import { Menu, X } from "lucide-react";
import { useState } from "react";


export default function Header() {
    // useState for hamburger menu.
    const [menuToggle, setMenuToggle] = useState(false);

    // Function for setting state.
    const toggleMenu = () => {
        setMenuToggle(toggle => !toggle);
        
    }
    // Mobile view. Changing CSS class depending on state. 
  return (
    <header className={styles.headerSection}>
        <h1 className={styles.headerTitle}>Animal Facts</h1>
        <section className={styles.headerMobileMenu}>
            <Menu className={menuToggle === true ? styles.lucideMenuIconToggled : styles.lucideMenuIcon} onClick={toggleMenu} size={48}/>
            <X className={menuToggle === true ? styles.lucideMenuIconCloseToggled : styles.lucideMenuIconClose} onClick={toggleMenu} size={48}/>
            <section className={menuToggle === true ? styles.headerMobile : styles.headerMobileToggled}>
                <nav className={styles.headerNavMobile}>
                <ul>
                    <li><Link href={"/"}>Home</Link></li>
                    <li><Link href={"/about"}>About</Link></li>
                    <li><Link href={"/"}>Random Animal</Link></li>
                </ul>
                </nav>
            </section>
        </section>
        {/* Desktop view */}
        <nav className={styles.headerNav}>
            <ul>
                <li><Link href={"/"}>Home</Link></li>
                <li><Link href={"/about"}>About</Link></li>
                <li><Link href={"/"}>Random Animal</Link></li>
            </ul>
        </nav>
    </header>
  )
}
