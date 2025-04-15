'use client'

import { usePathname, useRouter, useSearchParams } from "next/navigation"
import { useDebouncedCallback } from "use-debounce"
import styles from "./search.module.css"

// Searchbar using URL searchParams to send data to Query Component.
export default function Search() {
    const searchParams = useSearchParams();
    const pathName = usePathname();
    const { replace } = useRouter();

    const handleSearch = useDebouncedCallback((searchTerm: string) => {
        const params = new URLSearchParams(searchParams);
        if(searchTerm) {
            params.set('query', searchTerm);
        }
        else {
            params.delete('query');
        }
        replace(`${pathName}?${params.toString()}`);
    }, 300);
  return (
    <section className={styles.searchWrapper}>
        <label className={styles.searchLabel} htmlFor="searchbar">Search: </label>
        <input className={styles.searchInput} type="text" id="searchbar" placeholder="Search..." defaultValue={searchParams.get('query')?.toString()} onChange={(e) => {handleSearch(e.target.value)}}></input>
    </section>
  )
}
